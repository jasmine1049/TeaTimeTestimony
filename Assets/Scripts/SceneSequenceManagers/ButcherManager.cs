using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButcherManager : MonoBehaviour
{
    public DialogueManager dm;
    public DialogueTrigger butcherDialogue;
    public Button continueButton;
    bool goingThroughLastDialogue = false;
    public GameManager gm;
    public Dialogue nextScenePrompt;

    public GameObject grocer;
    DialogueTrigger grocerDialogue;

    void Start() 
    {
        grocer.SetActive(false);
    }

    void Update() 
    {
        if(butcherDialogue.triggered && !dm.isTalking)
        {
            grocer.SetActive(true);
            grocerDialogue = grocer.GetComponent<DialogueTrigger>();
            butcherDialogue.triggered = false;
        }
        if(grocerDialogue != null && grocerDialogue.triggered && !dm.isTalking) 
        {
            continueButton.onClick.AddListener(SwitchToMainMenu);
            grocerDialogue.triggered = false;
            dm.StartDialogue(nextScenePrompt);
        }
    }

    void SwitchToMainMenu()
    {
        GameObject m = FindObjectOfType<Music>().gameObject;
        Destroy(m);
        gm.SwitchScene("Menu");
    }
}
