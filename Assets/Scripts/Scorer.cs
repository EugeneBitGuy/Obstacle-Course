using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public int _hitTimes = 0;
    [SerializeField] private Text hitsTextField;
    [SerializeField] private Text minHitsTextField;

    public static Scorer Instance;

    private void Awake()
    {
        if (FindObjectsOfType<Scorer>().Length > 1)
        {
            DestroyImmediate(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("HitScore"))
        {
            minHitsTextField.text = $"Min hits: {PlayerPrefs.GetInt("HitScore")}";
        }
    }
    

    public void RaiseScore()
    {
        _hitTimes++;
        hitsTextField.text = $"Hits: {_hitTimes}";
    }
}
