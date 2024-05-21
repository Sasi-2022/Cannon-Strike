using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    
    public float speed = 10f;

    private bool collected = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the projectile collides with the collector
        if (other.CompareTag("Collector"))
        {
            // Mark the projectile as collected
            collected = true;
            // Disable the collider to prevent further interactions
            GetComponent<Collider2D>().enabled = false;
            // Set Rigidbody to kinematic
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.isKinematic = true;
            // Notify the GameManager that the projectile is collected
            GameManager.instance.IncreaseCollectedCount();
        }
    }

    public bool IsCollected()
    {
        return collected;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("obstacle"))
        {
            transform.position = new Vector2(3, 0);

        }
        if (collision.collider.CompareTag("Collector"))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;

        }
    }
}
