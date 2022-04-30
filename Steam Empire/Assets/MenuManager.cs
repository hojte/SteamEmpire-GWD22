using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
            Cursor.visible = false;
            FindObjectOfType<PlayerControl>().enablePlayerControls();
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void QuitGame()
    {
        JournalUpdate journal = GameObject.FindGameObjectWithTag("Player").GetComponent<JournalUpdate>();
        journal.restoreToDefaults();
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
    
}
