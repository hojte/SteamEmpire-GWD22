using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadingInCutscene : MonoBehaviour
{
    public GameObject uiCanvas;
    void Start()
    {
        uiCanvas = FindObjectOfType<Canvas>().gameObject;
    }

    public void cutsceneFadeToBlack()
    {
        StartCoroutine(uiCanvas.GetComponent<UIController>().FadeBlackOutSquare());
    }

    public void cutsceneFadeAwayFromBlack()
    {
        StartCoroutine(uiCanvas.GetComponent<UIController>().FadeBlackOutSquare(false));
    }
}
