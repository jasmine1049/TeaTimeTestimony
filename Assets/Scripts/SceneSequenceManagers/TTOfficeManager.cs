using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TTOfficeManager : MonoBehaviour
{
    public Canvas fadeCanvas;
    public Image fade;
    public DialogueTrigger startDialogue;

    public DialogueManager dm;
    public DialogueTrigger lastDialogue;
    public Button continueButton;
    bool goingThroughLastDialogue = false;
    public GameManager gm;
    public Dialogue nextScenePrompt;

    void Start()
    {
        StartCoroutine(FadeOutTransition());
    }

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

    IEnumerator FadeOutTransition() 
    {
        for (float fadeAmt = 2f; fadeAmt > 0; fadeAmt -= .01f)
        {
            if(fadeAmt < 1f)
            {
                fade.color = new Color(0f, 0f, 0f, fadeAmt);
            }
            yield return new WaitForSeconds(.01f);
        }
        fadeCanvas.enabled = false;
        //start dialogue
        startDialogue.TriggerDialogue();
    }
}
