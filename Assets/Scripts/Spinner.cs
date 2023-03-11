using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1f;

    public void Update()
    {
        Spin();
    }

    void Spin()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
