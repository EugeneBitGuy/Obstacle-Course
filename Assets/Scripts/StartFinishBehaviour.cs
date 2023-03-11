using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinishBehaviour : MonoBehaviour
{
    [SerializeField] private CanvasGroup startCanvas;
    [SerializeField] private CanvasGroup finishCanvas;

    [SerializeField] private PadType padType = PadType.Start;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            ShowCanvasGroup();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HideCanvasGroup();
        }
    }

    void ShowCanvasGroup()
    {
        switch (padType)
        {
            case PadType.Start:
                startCanvas.alpha = 1;
                break;
            case PadType.Finish:
                finishCanvas.alpha = 1;
                break;
        }
    }

    void HideCanvasGroup()
    {
        startCanvas.alpha = 0;
        finishCanvas.alpha = 0;
    }
}