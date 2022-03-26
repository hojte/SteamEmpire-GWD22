using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalAppear : MonoBehaviour
{
    [SerializeField]
    private Canvas _journalCanvas;


    private void Start()
    {
        _journalCanvas.enabled = false;
    }

    private void Update()
    {
        
            if (Input.GetKeyDown("tab"))
            {
                _journalCanvas.enabled = !_journalCanvas.enabled;
            }
    }
}
