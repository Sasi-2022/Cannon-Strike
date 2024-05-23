using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles6 : MonoBehaviour
{
    float rotationSpeed = 60;
    Vector3 currentEulerAngles;
    float z;
    public Transform pivotPoint;

    public void Start()
    {
        z = -1;
    }
    private void Update()
    {
        currentEulerAngles += new Vector3(0, 0, z) * Time.deltaTime * rotationSpeed;
        pivotPoint.localEulerAngles = currentEulerAngles;
    }

}
