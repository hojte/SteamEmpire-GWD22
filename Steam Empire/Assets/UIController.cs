using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    public GameObject blackOutSquare;

    public void Update() {
        if (Input.GetKeyDown(KeyCode.A))
            StartCoroutine(FadeBlackOutSquare());
        if (Input.GetKeyDown(KeyCode.S))
            StartCoroutine(FadeBlackOutSquare(false));
    }

    public void cutsceneFadeToBlack()
    {
        StartCoroutine(FadeBlackOutSquare());
    }

    public void cutsceneFadeAwayFromBlack()
    {
        StartCoroutine(FadeBlackOutSquare(false));
    }

    public IEnumerator FadeBlackOutSquare(bool fadeToBlack = true, int fadeSpeed = 2)
    {
        Color objectColor = blackOutSquare.GetComponent<RawImage>().color;
        float fadeAmount;

        if (fadeToBlack)
        {
            Debug.Log("fading to black");
            while (blackOutSquare.GetComponent<RawImage>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);
                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<RawImage>().color = objectColor;
                yield return null;
            }
        }
        else
        {
            Debug.Log("fading away from black");
            while (blackOutSquare.GetComponent<RawImage>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);
                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<RawImage>().color = objectColor;
                yield return null;
            }
        }
    }
}
