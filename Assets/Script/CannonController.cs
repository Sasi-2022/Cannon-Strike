using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CannonController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public int maxProjectiles = 30;
    private bool iscollided = false;
    public static Action text;

    private int currentProjectiles;
    public Text projectileCountText;

    void Start()
    {
        currentProjectiles = maxProjectiles;
      //  UpdateProjectileCountUI();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentProjectiles > 0)
        {
            FireProjectile();
        }

    }

    void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * projectile.GetComponent<ProjectileController>().speed;

        currentProjectiles--;
        text.Invoke();
       // UpdateProjectileCountUI();
    }

   /* void UpdateProjectileCountUI()
    {
        projectileCountText.text = currentProjectiles.ToString();
    }*/

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject); // Destroy the projectile
        }
    }
}
