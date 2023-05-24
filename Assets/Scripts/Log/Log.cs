using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.InputSystem;

struct LogEntry
{
    public string entry_name;
    public string entry_description;

    public LogEntry(string nm, string desc)
    {
        this.entry_name = nm;
        this.entry_description = desc;
    }
}

public class Log : MonoBehaviour
{
    List<LogEntry> playerLog;
    int activePosition = 0;
    int pageLength;

    [SerializeField] TextMeshProUGUI[] names;
    [SerializeField] TextMeshProUGUI[] descriptions;
    [SerializeField] GameObject logObject;

    private void Start() 
    {
        playerLog = new List<LogEntry>();
        logObject.SetActive(false);
        pageLength = names.Length;
        AddToLog("apple", "this is an apple");
        AddToLog("banana", "this is a banana");
        AddToLog("pancake", "this is a pancake");
        AddToLog("toast", "this is toast");
        AddToLog("hamburger", "this is hamburger");
    }

    private void OnLog() 
    {
        if(logObject.activeSelf)
        {
            logObject.SetActive(false);
        }
        else
        {
            DisplayLog();
        }
    }

    public void DisplayLog()
    {
        logObject.SetActive(true);
        for(int i = 0; i < names.Length; i++)
        {
            if(activePosition + i >= playerLog.Count)
            {
                names[i].text = "";
                descriptions[i].text = "";
            }
            else
            {
                names[i].text = playerLog[activePosition + i].entry_name;
                descriptions[i].text = playerLog[activePosition + i].entry_description;
            }
        }
    }

    public void LogPageForward()
    {
        if(activePosition + names.Length >= playerLog.Count)
        {
            return;
        }

        activePosition = activePosition + names.Length;
        DisplayLog();
    }

    public void LogPageBackward()
    {
        if(activePosition - names.Length < 0)
        {
            return;
        }

        activePosition = activePosition - names.Length;
        DisplayLog();
    }

    void AddToLog(string object_name, string object_description)
    {
        foreach (LogEntry le in playerLog)
        {
            if(object_name == le.entry_name)
            {
                return;
            }
        }

        LogEntry newEntry = new LogEntry(object_name, object_description);

        playerLog.Add(newEntry);
    }
}
