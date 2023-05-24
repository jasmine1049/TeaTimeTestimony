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

    // Start is called before the first frame update
    void Start()
    {
        tutorialText.text = "[WASD to Move]";
        initPlayerPosition = player.position;
        initObjPosition = obj.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position != initPlayerPosition) 
        {
            tutorialText.text = "";
        }

        if (inRange(player, initObjPosition))
        {
            tutorialText.text = "[E to Interact]";
        }
    }
}
