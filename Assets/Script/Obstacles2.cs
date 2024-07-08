using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles2 : MonoBehaviour
{
    public float rotationSpeed = 90.0f; 
    void Update()
    {
        float distance = 2f;
        float speed = 4f;

        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        float yPos = transform.position.y;
        float xPos = transform.position.x;
        float zPos = transform.position.z + speed * Time.deltaTime;

    }
}
