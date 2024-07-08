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

   

    private SpriteRenderer spriteRenderer;

    public Sprite[] balls;

    void Start()
    {
        currentProjectiles = maxProjectiles;
        //  UpdateProjectileCountUI();
        //text.Invoke();
        spriteRenderer = projectilePrefab.GetComponent<SpriteRenderer>();
        cannon.onClick.AddListener(FireProjectile);
       
    }

    void Update()
    {
        /*  if (Input.GetMouseButtonDown(0) && currentProjectiles > 0)
          {
              FireProjectile();
             // text.Invoke();
          }*/
        ButtonDisable();
    }

    void FireProjectile()
    {
      //  if (Levels.instance.pickedlevels == "Level1")
       // {
            spriteRenderer.sprite = balls[0];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

            
            
       // }
      /*  if (Levels.instance.pickedlevels == "Level2")
        {
            spriteRenderer.sprite = balls[1];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level3")
        {
            spriteRenderer.sprite = balls[2];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.right * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level4")
        {
            spriteRenderer.sprite = balls[3];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.left;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);

            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level5")
        {
            spriteRenderer.sprite = balls[4];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level6")
        {
            spriteRenderer.sprite = balls[5];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level7")
        {
            spriteRenderer.sprite = balls[6];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.right * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level8")
        {
            spriteRenderer.sprite = balls[7];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);

            currentProjectiles--;
            text.Invoke();

        }
        if (Levels.instance.pickedlevels == "Level9")
        {
            spriteRenderer.sprite = balls[8];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }*/

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject); // Destroy the projectile
        }
    }

   private void ButtonDisable()
    {
        if (UIManager.instance.currentProjectiles == 0)
        {
            cannon.interactable = false;
           
            
        }
    }
}
