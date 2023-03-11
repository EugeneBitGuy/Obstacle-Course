using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1f;
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    /*private void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float zMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        
        transform.Translate(xMovement, 0, zMovement);
    }*/

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
