using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public bool triggered = false;

    public void TriggerDialogue()
    {
        triggered = true;
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
