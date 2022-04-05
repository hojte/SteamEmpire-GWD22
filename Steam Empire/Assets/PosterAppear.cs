using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterAppear : MonoBehaviour
{
    [SerializeField]
    private Image _Image;

    private void Start()
    {
        _Image.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _Image.enabled = true; 
        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _Image.enabled = false; 
        }
    }
}
