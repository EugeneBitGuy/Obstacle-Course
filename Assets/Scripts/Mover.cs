using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1f;
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(xMovement, 0, zMovement).normalized * (movementSpeed * Time.fixedDeltaTime);
        
        _rigidbody.MovePosition(_rigidbody.position + movement);
    }



}
