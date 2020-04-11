using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum QuestDifficultyFactor { Easy, Medium, Hard, Impossible }
public class QuestObject : ScriptableObject
{
    [Header("Quest Info")]
    public string questName;
    public QuestDifficultyFactor questDifficulty;
    public int coinReward;
    public Item wantedItem;
    public float timeLimit; // In seconds
    [TextArea(2, 5)] // sets min and max lines for inspector
    public string questFlavourText;
    [TextArea(2, 3)] // sets min and max lines for inspector
    public string[] questSpecificAcceptanceDialogue;
    [TextArea(2, 3)] // sets min and max lines for inspector
    public string[] questSpecificCompletionDialogue;


}
