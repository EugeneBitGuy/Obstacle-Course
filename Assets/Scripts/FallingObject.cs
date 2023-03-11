using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    [SerializeField] private float waitTimeToFall;

    private Rigidbody _rigidbody;
    private MeshRenderer _renderer;

    private void Start()
    {
        _renderer= GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();

        StartCoroutine(WaitToFall());
    }

    IEnumerator WaitToFall()
    {
        yield return new WaitForSeconds(waitTimeToFall);

        Fall();
    }

    void Fall()
    {
        _renderer.enabled = true;
        _rigidbody.useGravity = true;
    }
}
