using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate17 : MonoBehaviour
{
    public float rotationSpeed = 90.0f;

    void Update()
    {
        float distance = 3f;
        float speed = 2f;

        float yPos = transform.position.y;
        float zPos = transform.position.z;
        float xPos = -Mathf.Sin(Time.time * speed) * distance; // Negate Mathf.Sin result

        transform.position = new Vector3(xPos, yPos, zPos);

    }
}
