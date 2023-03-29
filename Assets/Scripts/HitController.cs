using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    private MeshRenderer _renderer;

    [SerializeField] private Color hitColor = Color.red;
    
    private void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && !gameObject.CompareTag("Hit"))
            Hit();
    }

    void Hit()
    {
        _renderer.material.color = hitColor;
        
        gameObject.tag = "Hit";
        
        Scorer.Instance.RaiseScore();
    }
}
