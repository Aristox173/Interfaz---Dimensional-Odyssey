using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public ParticleSystem particleSystem; // Assign your particle system in the Unity Editor

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10; // Distance from the camera
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Set the position of the particle system to follow the mouse
        particleSystem.transform.position = worldMousePosition;
    }
}