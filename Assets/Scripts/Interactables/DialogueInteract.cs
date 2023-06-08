using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteract : Interactable
{
    public DialogueTrigger[] dialogueTriggers;
    int currentDialogue = 0;

    override public void Interact(GameObject player) 
    {
        if(currentDialogue >= dialogueTriggers.Length)
        {
            return;
        }
        dialogueTriggers[currentDialogue].TriggerDialogue();
        currentDialogue++;
    }
}
