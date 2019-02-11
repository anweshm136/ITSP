﻿using UnityEngine;
using System.Collections;

public class CamRotationX : MonoBehaviour
{

    public float rotationSpeed = 10;

    void Update()
    {
        Vector3 rotation = transform.eulerAngles;

        rotation.x += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime; // Standart Left-/Right Arrows and A & D Keys

        transform.eulerAngles = rotation;
    }
}
