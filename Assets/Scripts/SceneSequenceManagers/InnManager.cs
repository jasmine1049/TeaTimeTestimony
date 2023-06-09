using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InnManager : MonoBehaviour
{
    public DialogueManager dm;
    public DialogueTrigger lastDialogue;
    public Button continueButton;
    bool goingThroughLastDialogue = false;
    public GameManager gm;
    public Dialogue nextScenePrompt;

    void Update() 
    {
        if(goingThroughLastDialogue && !dm.isTalking)
        {
            continueButton.onClick.AddListener(SwitchToButcher);
            goingThroughLastDialogue = false;
            lastDialogue.triggered = false;
            dm.StartDialogue(nextScenePrompt);
        }
        if(lastDialogue.triggered)
        {
            goingThroughLastDialogue = true;
        }
    }

    void SwitchToButcher()
    {
        gm.SwitchScene("Butcher");
    }
}
