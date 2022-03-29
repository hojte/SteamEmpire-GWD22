using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbushEvent : MonoBehaviour
{
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private TextAsset dialogueAsset;

    [SerializeField] private UIController uiController;
    
    [SerializeField] private GameObject [] obstacles;

    [SerializeField] private Collider collider;
    

    //TODO: Maybe set position and cam rotation for player character to face main hoodlum properly
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerControl>();
        if (player != null)
        {
            dialogueManager.AssignStory(dialogueAsset);
            dialogueManager.GetCurrentStory.BindExternalFunction("knockout", () => EndScene());
            dialogueManager.InitDialogue();
            collider.enabled = false;
        }
    }

    //TODO: Push this to wherever fade to black and end of dialogue etc will be called 
 

    private void EndScene()
    {
        //Need to find a better way to do this, also issue with story when object disabled
        StartCoroutine(WaitThenKnockout());
        StartCoroutine(uiController.FadeBlackOutSquare());
    }

    private IEnumerator WaitThenKnockout()
    {
        //Replace coroutine with something event-driven, maybe reactive? Needs to play as soon as dialogue is over
        //and players might skip
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].SetActive(false);
        }

        StartCoroutine(uiController.FadeBlackOutSquare(fadeToBlack:false));
    }
    
}
