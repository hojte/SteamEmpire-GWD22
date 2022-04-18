using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class PosterAppear : MonoBehaviour
{
    [SerializeField]
    private Image _Image;
    
    public int posterId;

    private Text _interactText;
    private Text _headline;
    private Text _description;
    private Text _signing;

    private string[] headlineList = 
        {
        "Be Aware",
        "Stay inside", 
        "Keep distance", 
        "No leaving"
        };
    private string[] descriptionList = 
        {
        "All outdoor activity that is not permitted by the foreman  is cancelled between 3rd and 6th belling",
        "Under the instructions of the foreman everyone is ordered to stay inside the destrict",
        "Due to high risk of sickness everyone should keep a safe distance and go to the doctor you feel sick",
        "By the order of the foreman no one is permitted to leave the city district until further notice"
        };
    private string[] signingList =
        {
        "Foreman",
        "Foreman",
        "Doctor",
        "Foreman"
        };

    private void Awake()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, headlineList.Length);
        


        _interactText = GameObject.Find("UIInteract").GetComponent<Text>();
        _headline = GameObject.Find("Headline").GetComponent<Text>();
        _description = GameObject.Find("Description").GetComponent<Text>();
        _signing = GameObject.Find("Signing").GetComponent<Text>();

        _interactText.enabled = false;
        _headline.enabled = false;
        _description.enabled = false;
        _signing.enabled = false;

        

        _Image.enabled = false;

    }
    private void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            _interactText.enabled = true;
        }
    }

    void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (Input.GetKey("e")) {
                _Image.enabled = true;
                _headline.enabled = true;
                _description.enabled = true;
                _signing.enabled = true;

                _interactText.enabled = false;

                _headline.text = headlineList[posterId];
                _description.text = descriptionList[posterId];
                _signing.text = signingList[posterId];

            }

        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            _Image.enabled = false;
            _headline.enabled = false;
            _description.enabled = false;
            _signing.enabled = false;
            _interactText.enabled = false;
        }
    }
}
