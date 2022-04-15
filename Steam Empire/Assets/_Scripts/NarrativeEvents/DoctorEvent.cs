using System;
using System.Collections;
using System.Collections.Generic;
using Ink.Runtime;
using UnityEditor;
using UnityEngine;

public class DoctorEvent : MonoBehaviour
{
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private TextAsset textAsset;

    [SerializeField] private UIController uiController;

    private void Start()
    {
        dialogueManager.dialogueExit.AddListener(TriggerPassout);
    }

    private void TriggerPassout()
    {
        Story story = dialogueManager.GetCurrentStory;
        story.ObserveVariable("doctor_passout", ((variableName, value) =>
        {
            bool passedOut = (bool) value;
            if (passedOut)
            {
                StartCoroutine(Passout());
            }
        }));
    }

    private IEnumerator Passout()
    {
        StartCoroutine(uiController.FadeBlackOutSquare());
        yield return new WaitForSeconds(5f);
        StartCoroutine(uiController.FadeBlackOutSquare(fadeToBlack:false));
        dialogueManager.EnterDialogueMode(textAsset);
    }
}
