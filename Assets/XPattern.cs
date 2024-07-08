using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPattern : MonoBehaviour
{
    public float distance = 2f;
    public float speed = 2f;
    public bool invertX = false;
    public bool invertY = false;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float xPos = Mathf.Sin(Time.time * speed) * distance;
        float yPos = Mathf.Sin(Time.time * speed) * distance;

        if (invertX)
        {
            xPos = -xPos;
        }

        if (invertY)
        {
            yPos = -yPos;
        }

        transform.position = new Vector3(startPosition.x + xPos, startPosition.y + yPos, startPosition.z);
    }
}
