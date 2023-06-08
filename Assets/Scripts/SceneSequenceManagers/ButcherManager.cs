using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButcherManager : MonoBehaviour
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
            continueButton.onClick.AddListener(SwitchToInn);
            goingThroughLastDialogue = false;
            lastDialogue.triggered = false;
            dm.StartDialogue(nextScenePrompt);
        }
        if(lastDialogue.triggered)
        {
            goingThroughLastDialogue = true;
        }
    }

    void SwitchToInn()
    {
        gm.SwitchScene("Inn");
    }
}