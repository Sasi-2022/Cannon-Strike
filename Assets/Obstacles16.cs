using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles16 : MonoBehaviour
{
    public float rotationSpeed = 90.0f; 
    public float speed = 4f; 

    private bool isClockwise = true; 

    void Update()
    {
        if (Time.time % 4 < 2) 
        {
            isClockwise = true;
        }
        else 
        {
            isClockwise = false;
        }

        float direction = isClockwise ? 1 : -1;

        transform.Rotate(0, 0, direction * rotationSpeed * Time.deltaTime);

        float zPos = transform.position.z + speed * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, transform.position.y, zPos);
    }
}
