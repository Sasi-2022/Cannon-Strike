using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles2 : MonoBehaviour
{
    public float rotationSpeed = 90.0f; // Speed of rotation in degrees per second

    void Update()
    {
        float distance = 2f;
        float speed = 4f;

        // Update rotation around the z-axis
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        // Update position, keeping y and x positions unchanged
        float yPos = transform.position.y;
        float xPos = transform.position.x;
        float zPos = transform.position.z + speed * Time.deltaTime;

       // transform.position = new Vector3(xPos, yPos, zPos);
    }
}
