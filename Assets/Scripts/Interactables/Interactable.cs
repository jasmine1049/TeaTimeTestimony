using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Interactable : MonoBehaviour
{
    public string itemName;
    public string itemDescription;
    // private bool inRange = false;
    private void OnTriggerEnter(Collider other) {
        // I'm disabling these functions because this other script handles it
        // "Player Assets"/Scripts/Interactions.cs
        
        // if (other.gameObject.CompareTag("Player"))
        // {
        //     inRange = true;
        //     obj = other.GetComponent<Interactable>();
        // }
    }
    
    private void OnTriggerExit(Collider other) {
        // if (other.gameObject.CompareTag("Player"))
        // {
        //     inRange = false;
        //     obj = null;
        // }
    }

    abstract public void Interact(GameObject player);
}
