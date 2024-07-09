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
       // UpdateProjectileCountUI();
        text.Invoke();
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
          if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel==1)
          {
            spriteRenderer.sprite = balls[0];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

            
            
          }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 2)
        {
            spriteRenderer.sprite = balls[1];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 3)
        {
            spriteRenderer.sprite = balls[2];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.right * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 4)
        {
            spriteRenderer.sprite = balls[3];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.left;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);

            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 5)
        {
            spriteRenderer.sprite = balls[4];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 6)
        {
            spriteRenderer.sprite = balls[5];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 7)
        {
            spriteRenderer.sprite = balls[6];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);

            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 8)
        {
            spriteRenderer.sprite = balls[7];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);

            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 9)
        {
            spriteRenderer.sprite = balls[8];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 10)
        {
            spriteRenderer.sprite = balls[0];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 11)
        {
            spriteRenderer.sprite = balls[1];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.left;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 12)
        {
            spriteRenderer.sprite = balls[2];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 13)
        {
            spriteRenderer.sprite = balls[3];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 14)
        {
            spriteRenderer.sprite = balls[3];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 15)
        {
            spriteRenderer.sprite = balls[7];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);

            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 16)
        {
            spriteRenderer.sprite = balls[5];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 17)
        {
            spriteRenderer.sprite = balls[6];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 18)
        {
            spriteRenderer.sprite = balls[7];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 19)
        {
            spriteRenderer.sprite = balls[8];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 20)
        {
            spriteRenderer.sprite = balls[0];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 21)
        {
            spriteRenderer.sprite = balls[1];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.left;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);

            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 22)
        {
            spriteRenderer.sprite = balls[2];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 23)
        {
            spriteRenderer.sprite = balls[3];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);

            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 24)
        {
            spriteRenderer.sprite = balls[4];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 25)
        {
            spriteRenderer.sprite = balls[5];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 26)
        {
            spriteRenderer.sprite = balls[6];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 27)
        {
            spriteRenderer.sprite = balls[7];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 28)
        {
            spriteRenderer.sprite = balls[8];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 29)
        {
            spriteRenderer.sprite = balls[0];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 30)
        {
            spriteRenderer.sprite = balls[1];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.left;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 31)
        {
            spriteRenderer.sprite = balls[2];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 32)
        {
            spriteRenderer.sprite = balls[3];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 33)
        {
            spriteRenderer.sprite = balls[4];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 34)
        {
            spriteRenderer.sprite = balls[5];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 35)
        {
            spriteRenderer.sprite = balls[6];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 36)
        {
            spriteRenderer.sprite = balls[7];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.left;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 37)
        {
            spriteRenderer.sprite = balls[8];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 38)
        {
            spriteRenderer.sprite = balls[0];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.left;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 39)
        {
            spriteRenderer.sprite = balls[1];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 40)
        {
            spriteRenderer.sprite = balls[2];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 41)
        {
            spriteRenderer.sprite = balls[3];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 42)
        {
            spriteRenderer.sprite = balls[4];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 43)
        {
            spriteRenderer.sprite = balls[5];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 44)
        {
            spriteRenderer.sprite = balls[6];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 45)
        {
            spriteRenderer.sprite = balls[7];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 46)
        {
            spriteRenderer.sprite = balls[8];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 47)
        {
            spriteRenderer.sprite = balls[0];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.right;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 48)
        {
            spriteRenderer.sprite = balls[1];
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 49)
        {
            spriteRenderer.sprite = balls[2];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.left;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            currentProjectiles--;
            text.Invoke();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 50)
        {
            spriteRenderer.sprite = balls[3];
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            Vector2 shootDirection = Vector2.left;

            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
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

   private void ButtonDisable()
    {
        if (UIManager.instance.currentProjectiles == 0)
        {
            cannon.interactable = false;
           
            
        }
    }
}
