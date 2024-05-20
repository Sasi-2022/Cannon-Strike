using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private bool hasEnteredBox = false;
    public Transform boxTransform;
    public float speed = 10f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ProjectileBoxCollider"))
        {
            hasEnteredBox = true;
            // Disable the projectile's Rigidbody to stop it from moving
            GetComponent<Rigidbody2D>().simulated = false;
            // Remember the box's transform for positioning
            boxTransform = other.transform;
        }
    }

    void Update()
    {
        if (hasEnteredBox && boxTransform != null)
        {
            // Move the projectile to the center of the box collider
            transform.position = boxTransform.position * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Add code here to handle collision with targets or boundaries
        // In this case, since we're collecting the projectile, we don't destroy it on collision
    }
}
