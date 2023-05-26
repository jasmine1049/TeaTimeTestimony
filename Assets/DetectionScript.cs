using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectionScript : MonoBehaviour
{
    public Transform player;
    public Text tutorialText;
    public Transform obj;

    private Vector3 initPlayerPosition;
    private Vector3 initObjPosition;

    private float timeLeft;
    private string oldTutText;

    public Dialogue tutorialDialogue;

    public bool inRange(Transform playerObj, Vector3 initGameObjPosition)
    {
        float lowXRange = initGameObjPosition.x - 2;
        float highXRange = initGameObjPosition.x + 2;

        float lowZRange = initGameObjPosition.z - 2;
        float highZRange = initGameObjPosition.z + 2;

        if (((lowXRange < playerObj.position.x) && (playerObj.position.x < highXRange)) && 
                ((lowZRange < playerObj.position.z) && (playerObj.position.z < highZRange))) 
        {
            return true;
        }

        return false;
    }

    public bool countDown() 
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            return true;
        }

        timeLeft = (float) 3;
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        tutorialText.text = "[WASD to Move]";
        initPlayerPosition = player.position;
        initObjPosition = obj.position;
        timeLeft = 0;
        oldTutText = tutorialText.text;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(tutorialText.text == "[E to Interact]"))
        {
            oldTutText = tutorialText.text;
        }        

        if (inRange(player, initObjPosition))
        {
            tutorialText.text = "[E to Interact]";
            if(Input.GetKeyDown("e"))
            {
                FindObjectOfType<DialogueManager>().StartDialogue(tutorialDialogue);
            }
        }
        else
        {
            tutorialText.text = oldTutText;
        }

        if (player.position != initPlayerPosition)
        {
            Debug.Log(timeLeft);
            if (!countDown())
            {
                if (tutorialText.text == "")
                {
                    tutorialText.text = "[TAB to Open Map]";
                }
                else if (tutorialText.text == "[TAB to Open Map]")
                {
                    tutorialText.text = "[Q to Open Notebook]";
                }
                else
                {
                    tutorialText.text = "";
                }
            }
        }
    }
}
