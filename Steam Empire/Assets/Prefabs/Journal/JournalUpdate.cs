using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class JournalUpdate : MonoBehaviour
{
    // [SerializeField]
    private Canvas _journalCanvas;
    public int storyProgression = 1;

    private void Start()
    {
        _journalCanvas = GameObject.Find("DiaryCanvas").GetComponent<Canvas>();
        _journalCanvas.enabled = false;
    }


    public static void WriteString(Canvas journalCanvas, int entry, bool scribble)
    {
        string path = "Assets/Prefabs/Journal/journal.txt";

        int line_to_edit = entry; // Warning: 1-based indexing!
        string sourceFile = "Assets/Prefabs/Journal/journal.txt";
        string destinationFile = "Assets/Prefabs/Journal/journal.txt";

        // Read the appropriate line from the file.
        string lineToWrite = null;
        using (StreamReader reader = new StreamReader(sourceFile))
        {
            for (int i = 1; i <= line_to_edit; ++i)
                lineToWrite = reader.ReadLine();
            
        }

        if (lineToWrite == null)
            throw new InvalidDataException("Line does not exist in " + sourceFile);
        
        if (scribble)
            lineToWrite = entry.ToString() + " clue:true:true";
        else
            lineToWrite = entry.ToString() + " clue:true:false";

        // Read the old file.
        string[] lines = File.ReadAllLines(destinationFile);

        

        // Write the new file over the old file.
        using (StreamWriter writer = new StreamWriter(destinationFile))
        {
            for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
            {
                if (currentLine == line_to_edit)
                {
                    writer.WriteLine(lineToWrite);
                }
                else
                {
                    writer.WriteLine(lines[currentLine - 1]);
                }
            }
        }



    }

    public void restoreToDefaults()
    {
        string path = "Assets/Prefabs/Journal/journal.txt";
        File.WriteAllText(path, String.Empty);
        TextWriter tw = new StreamWriter(path, true);
        tw.WriteLine("1 clue:true:false");

        int amountOfEntries = 8;
        
        for (int i = 2; i <= amountOfEntries; i++)
            tw.WriteLine(i.ToString() + " clue:false:false");
        
        tw.Close();
    }

    public void updateJournal(int entry, bool scribble)
    {

        WriteString(_journalCanvas, entry, scribble);

        if (!scribble)
        {
            storyProgression = entry;

            //TODO MATHIAS ADD SHIT HERE, yes, inside the if
        }

    }
}
