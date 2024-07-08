using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate25 : MonoBehaviour
{
    public Transform target; // Target object to orbit around
    public float orbitSpeed = 20f; // Speed of orbit in degrees per second
    public float distance = 10f; // Distance from the target

    void Update()
    {
        // Calculate the current position in the orbit
        Vector3 offset = new Vector3(0f, distance, 0f);
        Vector3 position = target.position + offset;

        // Rotate around the target using the orbitSpeed
        transform.RotateAround(target.position, Vector3.forward, orbitSpeed * Time.deltaTime);

        // Update the position of the object
        transform.position = position;
    }
}
