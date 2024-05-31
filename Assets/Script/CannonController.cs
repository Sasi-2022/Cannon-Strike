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
    public Transform shootPoint;
    private int currentProjectiles;
   // public Text projectileCountText;

    // Force to be applied to the projectile
    public float shootForce = 10f;

    public Button cannon;

    void Start()
    {
        currentProjectiles = maxProjectiles;
        //  UpdateProjectileCountUI();
        //text.Invoke();
        cannon.onClick.AddListener(FireProjectile);
    }

    void Update()
    {
      /*  if (Input.GetMouseButtonDown(0) && currentProjectiles > 0)
        {
            FireProjectile();
           // text.Invoke();
        }*/

    }

    void FireProjectile()
    {
        if (Levels.instance.pickedlevels == "Level1")
        {

            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level2")
        {

            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level3")
        {

            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.right * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level4")
        {

            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.left;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);

            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level5")
        {

            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level6")
        {

            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level7")
        {

            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.right * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level8")
        {

            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);

            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level9")
        {

            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject); // Destroy the projectile
        }
    }
}
