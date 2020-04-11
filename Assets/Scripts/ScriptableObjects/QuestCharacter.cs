using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Quest Character", menuName = "NPC / Quest Giver")]
public class QuestCharacter : CharacterObject
{
    public Quest[] possibleQuests;
}
