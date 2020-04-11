using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//[CreateAssetMenu(fileName = "new playerprofile", menuName = "Player / Player Data")]
[System.Serializable]


public class PlayerVariables : ScriptableObject
{
    [Header("Player Info")]
    public string playerName;
    public int playerDebt;
    public int playerWallet;
    public float totalDistanceTravelled;    
    public int questsCompleted;    
    public float timePlayed;

    [Header("Player Location")]
    public float x;
    public float y;
    public float z;





}
