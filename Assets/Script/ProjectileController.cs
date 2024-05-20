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
            // Notify the GameManager that the projectile is collected
            GameManager.instance.IncreaseCollectedCount();
        }
    }

    public bool IsCollected()
    {
        return collected;
    }
}
