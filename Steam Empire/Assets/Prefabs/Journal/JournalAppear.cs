using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class JournalAppear : MonoBehaviour
{
    [SerializeField]
    private Canvas _journalCanvas;


    private void Start()
    {
        _journalCanvas = GameObject.Find("DiaryCanvas").GetComponent<Canvas>();
        _journalCanvas.enabled = false;
    }

    private void Update()
    {
        
            if (Input.GetKeyDown("tab"))
            {
                _journalCanvas.enabled = !_journalCanvas.enabled;
                ReadString(_journalCanvas);
            }
            
    }
    
    [MenuItem("Tools/Read file")]
    static void ReadString(Canvas journalCanvas)
    {
        string path = "Assets/Prefabs/Journal/journal.txt";
        //Read the text from directly from the test.txt file
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                String[] lines = line.Split(':');
                journalCanvas.transform.Find(lines[0]).GetComponent<Text>().enabled = bool.Parse(lines[1]);
                journalCanvas.transform.Find(lines[0]+" line").GetComponent<Text>().enabled = bool.Parse(lines[2]);
                Debug.Log(line);
                
            }
            //reader.Close();
        }

    }
}
