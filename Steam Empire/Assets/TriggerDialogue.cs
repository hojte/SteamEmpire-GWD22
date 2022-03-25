using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private TextAsset dialogueAsset;
    
    //TODO: Maybe set position and cam rotation for player character to face main hoodlum properly
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerControl>();
        if (player != null)
            dialogueManager.EnterDialogueMode(dialogueAsset);
    }

    //TODO: Push this to wherever fade to black and end of dialogue etc will be called 
    private void OnTriggerExit(Collider other)
    {
        var player = other.GetComponent<PlayerControl>();
        if (player != null)
            Destroy(gameObject);
    }
    
}
