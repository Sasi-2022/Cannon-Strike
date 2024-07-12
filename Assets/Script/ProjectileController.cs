using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProjectileController : MonoBehaviour
{
    public float speed = 1f;
    private bool collected = false;
    public static Action ballcollection;
    public static Action lossballCount;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collect"))
        {
           // CollectBall();
            ballcollection.Invoke();
            StartCoroutine(BallBounce());
        }
        if (other.CompareTag("LossBalls"))
        {
            lossballCount.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("obstacle"))
        {
            
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 1)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 80f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 2)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 80f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 3)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 15f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 4)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 25f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 5)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 15f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 6)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 7)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 8)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 9)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 10)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 18f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 11)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 12)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 15f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 13)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 15f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 14)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 14f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 15)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 16)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 17)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 18)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 16f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 19)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 20)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 21)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 22)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 16f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 23)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 24)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 25)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 26)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 16f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 27)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 28)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 30)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 31)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 32)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 33)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 34)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 35)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 36)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 37)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 38)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 39)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 40)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 41)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 16f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 42)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 16f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 43)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 16f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 44)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 16f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 45)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 46)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 47)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 48)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 49)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
                if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 50)
                {
                    Vector2 direction = (collision.transform.position - transform.position).normalized;
                    rb.AddForce(-direction * 20f, ForceMode2D.Impulse);
                }
            }
        }
       else if (collision.collider.CompareTag("Collector"))
       {
            // PhysicsMaterial2D newMaterial = new PhysicsMaterial2D();
            //  newMaterial.bounciness = 0f;

            Debug.Log("b---");
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            

           // rb.constraints = RigidbodyConstraints2D.FreezePositionY;
       }


    }


    private void CollectBall()
    {
        collected = true;
        gameObject.SetActive(true); 
    }

    public bool IsCollected()
    {
        return collected;
    }

    private IEnumerator BallBounce()
    {
        PhysicsMaterial2D newMaterial = new PhysicsMaterial2D();
         newMaterial.bounciness = 0.8f;

        transform.Rotate(Vector3.up, 5 * Time.deltaTime);

        yield return new WaitForSeconds(0.1f);

        newMaterial.bounciness = 0f;

        transform.Rotate(Vector3.up * Time.deltaTime);
    }

}


