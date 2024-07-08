using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        float distance = 1f;
        float speed = 2f;

        float yPos = transform.position.y;
        float zPos = Mathf.Sin(Time.time * speed) * distance;
        float xPos = transform.position.x;

        transform.position = new Vector3(xPos, yPos, zPos);
    }
}
