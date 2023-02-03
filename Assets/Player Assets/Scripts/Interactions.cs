using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    bool inRange = false;
    Interactable obj;

    private void OnTriggerEnter(Collider other) {
        inRange = true;
        obj = other.GetComponent<Interactable>();
    }
    
    private void OnTriggerExit(Collider other) {
        inRange = false;
        obj = null;
    }

    private void Update() {
        if (!inRange) { return; }

        if (Input.GetKeyDown("e"))
        {
            obj.Interact(gameObject);
        }
    }

    public void sayHI() {
        Debug.Log("HI");
    }
}
