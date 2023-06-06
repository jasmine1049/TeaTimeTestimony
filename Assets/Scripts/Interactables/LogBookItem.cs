using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogBookItem : Interactable
{
    private bool acquired = false;
    private Log logbook;

    private void Start()
    {
        // Warning: Hardcoded to search for name "Log"
        logbook = GameObject.Find("Log").GetComponent<Log>();
    }

    override public void Interact(GameObject player)
    {
        if (!acquired)
        {
            Debug.Log(string.Format("acquired {0}", itemName));
            
            logbook.AddToLog(itemName, itemDescription);
            acquired = true;
        }
    }
}
