using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    private int _hitTimes = 0;
    [SerializeField] private Text hitsTextField;

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
        hitsTextField.text = $"Hits: {_hitTimes}";
    }
}
