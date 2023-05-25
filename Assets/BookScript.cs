using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookScript : MonoBehaviour
{
    public Image notebook;
    
    private bool notebookOn;

    // Start is called before the first frame update
    void Start()
    {
        notebook.enabled = false;
        notebookOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (notebookOn)
            {
                notebook.enabled = false;
                notebookOn = false;
            }
            else
            {
                notebook.enabled = true;
                notebookOn = true;
            }
        }
    }
}
