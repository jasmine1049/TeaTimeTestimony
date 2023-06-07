using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteract : Interactable
{
    public DialogueTrigger dialogueTrigger;

    override public void Interact(GameObject player) 
    {
        dialogueTrigger.TriggerDialogue();
    }
}
