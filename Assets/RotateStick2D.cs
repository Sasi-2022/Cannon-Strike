using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStick2D : MonoBehaviour
{
    public float rotationSpeed = 80f;
    private float z;
    public Transform pivotPoint;

    void Start()
    {
        z = -1;
    }

    void Update()
    {
        // Calculate the angle to rotate
        float angle = z * Time.deltaTime * rotationSpeed;

        // Rotate around the pivot point's Z-axis
        pivotPoint.Rotate(0, 0, angle);
    }

}
