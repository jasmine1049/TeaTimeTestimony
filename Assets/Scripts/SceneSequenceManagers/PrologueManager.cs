using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrologueManager : MonoBehaviour
{
    public DialogueManager dm;
    public DialogueTrigger dt;
    bool talkedToAldo = false;
    bool startingTTSequence = false;
    public Canvas fadeCanvas;
    public Image fade;
    public GameManager gm;

    void Start() 
    {
        fadeCanvas.enabled = false;
    }
    
    void Update() 
    {
        if(!dm.isTalking && talkedToAldo && !startingTTSequence)
        {
            TimeTravelSequence();
            startingTTSequence = true;
        }
        if(dt.triggered)
        {
            talkedToAldo = true;
        }
    }

    void TimeTravelSequence() 
    {
        Debug.Log("Start time travel");
        fadeCanvas.enabled = true;
        StartCoroutine(TimeTravelTransition());
    }

    IEnumerator TimeTravelTransition() 
    {
        for (float fadeAmt = 0f; fadeAmt <= 1; fadeAmt += .01f)
        {
            fade.color = new Color(0f, 0f, 0f, fadeAmt);
            yield return new WaitForSeconds(.01f);
        }
        gm.SwitchScene("TTOffice");
    }
}
