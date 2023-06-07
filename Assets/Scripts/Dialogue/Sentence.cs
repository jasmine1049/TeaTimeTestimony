using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sentence
{
    public string speakerName;
    [TextArea(3,5)]
    public string sentenceText;
    public Sprite talkerImage;
    public bool introduceSpeaker;
    public bool isMC;
    public bool[] removeSpeaker; // array size 2. true = remove this speaker. array[i] = remove speaker i.
    public bool usesAnimation = true; //defaults to true bc i don't wanna replace the existing ones that already use animations ;))
}
