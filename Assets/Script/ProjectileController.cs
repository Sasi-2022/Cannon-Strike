using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProjectileController : MonoBehaviour
{
    public float speed = 1f;
    private bool collected = false;
    public static Action ballcollection;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collector"))
        {
            CollectBall();
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
                rb.AddForce(-direction * 60f, ForceMode2D.Impulse); 
            }
        }
        if (collision.collider.CompareTag("Collector"))
        {
            Debug.Log("b---");
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            //ballcollection.Invoke();
           // rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }


    }


    private void CollectBall()
    {
        collected = true;
        gameObject.SetActive(false); 
        GameManager.instance.IncreaseCollectedCount(); 
    }

    public bool IsCollected()
    {
        return collected;
    }

}


