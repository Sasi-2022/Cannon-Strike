using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = 1f;
        float speed = 2f;

        float yPos = transform.position.y;
        float zPos = transform.position.z;
        float xPos = Mathf.Sin(Time.time * speed) * distance;

        transform.position = new Vector3(xPos, yPos, zPos);
    }
}
