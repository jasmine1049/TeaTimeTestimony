using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteract : Interactable
{
    // Simple interactable object class that prints to console.log on interaction
    //  Use this for debugging, and checking that the Interactable inheritance
    //  tree is working as intended
    private int interactCount = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(string.Format("Entered Interact range of {0}", itemName));
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(string.Format("Exited Interact range of {0}", itemName));
    }

    override public void Interact(GameObject player)
    {
        interactCount++;
        Debug.Log(string.Format("Interacted with {0} {2} times - {1}", 
            itemName, itemDescription, interactCount));
    }
}
