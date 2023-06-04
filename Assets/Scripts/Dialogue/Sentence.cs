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
}
