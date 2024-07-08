using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate30 : MonoBehaviour
{
    public float rotationSpeed = 60f;
    public Transform pivotPoint;
    public float maxRotationAngle = 45f;

    private float zRotation = 0f;
    private bool rotatingForward = true;

    void Update()
    {
        float rotationStep = rotationSpeed * Time.deltaTime;

        if (rotatingForward)
        {
            zRotation += rotationStep;
            if (zRotation >= maxRotationAngle)
            {
                zRotation = maxRotationAngle;
                rotatingForward = false;
            }
        }
        else
        {
            zRotation -= rotationStep;
            if (zRotation <= -maxRotationAngle)
            {
                zRotation = -maxRotationAngle;
                rotatingForward = true;
            }
        }

        pivotPoint.localEulerAngles = new Vector3(0, 0, zRotation);
    }
}
