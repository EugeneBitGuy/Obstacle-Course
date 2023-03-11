using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _hitTimes = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            RaiseScore();
        }
    }

    void RaiseScore()
    {
        _hitTimes++;
        Debug.Log($"U hit object {_hitTimes} times in this session.");
    }
}
