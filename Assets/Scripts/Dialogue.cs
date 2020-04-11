using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public CharacterObject NPCData;

    [TextArea(2,4)]
    public string[] sentences;

    // Start is called before the first frame update
    void Start()
    {

    }

}
