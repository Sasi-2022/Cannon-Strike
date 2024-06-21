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
                Vector2 direction = (collision.transform.position - transform.position).normalized;
                rb.AddForce(-direction * 45f, ForceMode2D.Impulse);
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


