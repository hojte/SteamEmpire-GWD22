using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterAppear : MonoBehaviour
{
    [SerializeField]
    private Image _Image;

    private Text _interactText;


    private void Start()
    {
        _interactText = GameObject.Find("UIInteract").GetComponent<Text>();
        _interactText.enabled = false;
        _Image.enabled = false;
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
                _interactText.enabled = false;

            }

        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _interactText.enabled = false;
            _Image.enabled = false; 
        }
    }
}
