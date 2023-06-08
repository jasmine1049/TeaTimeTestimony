using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Animator textBoxAnimator;
    public Animator fadeAnimator;

    //VN Character Display
    public Image leftCharacterImage;
    public Animator leftImageAnimator;
    public Image rightCharacterImage;
    public Animator rightImageAnimator;

    public bool isTalking = false;

    Queue<Sentence> sentences;

    void Start()
    {
        sentences = new Queue<Sentence>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        isTalking = true;
        textBoxAnimator.SetBool("IsOpen", true);
        fadeAnimator.SetBool("IsOpen", true);
        
        sentences.Clear();

        foreach(Sentence s in dialogue.sentences)
        {
            sentences.Enqueue(s);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        Sentence s = sentences.Dequeue();
        nameText.fontSize = (s.speakerName.Length > 8)? 35: 50;

        if(s.usesAnimation) 
        {
            if(s.introduceSpeaker == true) 
            {
                if(s.isMC == true)
                {
                    leftCharacterImage.sprite = s.talkerImage;
                    leftImageAnimator.SetBool("IsOpen", true);
                }
                else
                {
                    rightCharacterImage.sprite = s.talkerImage;
                    rightImageAnimator.SetBool("IsOpen", true);
                }
            }

            if(s.removeSpeaker.Length > 0)
            {
                if(s.removeSpeaker[0] == true)
                {
                    leftImageAnimator.SetBool("IsSpeaking", false);
                    leftImageAnimator.SetBool("IsOpen", false);
                }
                if(s.removeSpeaker[1] == true)
                {
                    Debug.Log("remove right");
                    rightImageAnimator.SetBool("IsSpeaking", false);
                    rightImageAnimator.SetBool("IsOpen", false);
                }
            }
            else
            {
                if(s.isMC == true) 
                {
                    rightImageAnimator.SetBool("IsSpeaking", false);
                    leftImageAnimator.SetBool("IsSpeaking", true);
                }
                else
                {
                    leftImageAnimator.SetBool("IsSpeaking", false);
                    rightImageAnimator.SetBool("IsSpeaking", true);
                }
            }
        }

        nameText.text = s.speakerName;
        StopAllCoroutines();
        dialogueText.text = s.sentenceText;
        //StartCoroutine(TypeSentence(s.sentenceText));
    }

    IEnumerator TypeSentence(string sentence) 
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.025f); //wait 0.025 seconds before printing the next letter.
        }
    }

    public void EndDialogue()
    {
        textBoxAnimator.SetBool("IsOpen", false);
        fadeAnimator.SetBool("IsOpen", false);

        if(leftImageAnimator != null && rightImageAnimator != null)
        {
            leftImageAnimator.SetBool("IsSpeaking", false);
            rightImageAnimator.SetBool("IsSpeaking", false);
            leftImageAnimator.SetBool("IsOpen", false);
            rightImageAnimator.SetBool("IsOpen", false);
        }

        Debug.Log("End of conversation.");
        isTalking = false;
    }
}
