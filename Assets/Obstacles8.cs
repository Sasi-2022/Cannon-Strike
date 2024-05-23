using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles8 : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        float distance = 2f;
        float speed = 2f;

        float yPos = Mathf.Sin(Time.time * speed) * distance;
        float zPos = transform.position.z;
        float xPos = transform.position.x;

        transform.position = new Vector3(xPos, yPos, zPos);
    }
}
