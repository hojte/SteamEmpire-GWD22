using System;
using System.Collections;
using System.Collections.Generic;
using Ink.Runtime;
using UnityEditor;
using UnityEngine;

public class DoctorEvent : MonoBehaviour
{
    
    //TODO: Can re-trigger dialogue after cutscene --> breaks dialogue, disable interactable?
    
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private TextAsset initialDocTextAsset;
    [SerializeField] private TextAsset finalDocTextAsset;

    [SerializeField] private UIController uiController;

    private PlayerControl _playerController = null;

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerControl>();
        if (player != null)
        {
            dialogueManager.AssignStory(initialDocTextAsset);
            bool infectionReveal = (bool) dialogueManager.GetCurrentStory.variablesState["infection_reveal"];
            _playerController = player;
            if (infectionReveal)
            {
                print("Infection reveal: " + infectionReveal);
                
                dialogueManager.AssignStory(finalDocTextAsset);
            }
            else
            {
                print("first story assigned");
                dialogueManager.AssignStory(initialDocTextAsset);
                dialogueManager.dialogueExit.AddListener(TriggerPassout);
            }
        }
    }

    private void TriggerPassout()
    {
        StartCoroutine(Passout());
        dialogueManager.dialogueExit.RemoveAllListeners();
    }

    private IEnumerator Passout()
    {
        //_playerController.disablePlayerControls();
        StartCoroutine(uiController.FadeBlackOutSquare());
        yield return new WaitForSeconds(5f);
        StartCoroutine(uiController.FadeBlackOutSquare(fadeToBlack:false));
        //_playerController.enablePlayerControls();
        //_playerController = null;
        dialogueManager.EnterDialogueMode(finalDocTextAsset);
    }
}
