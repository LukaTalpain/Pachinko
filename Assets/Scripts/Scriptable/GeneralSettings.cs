using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class GeneralSettings : ScriptableObject
{
    public int StartingNumberOfBalls = 10;
    

    [Header("Value Slots")]
    public int Slot0_5;
    public int Slot1_4;
    public int Slot2_3;
    public int BonusOriginalValue;


    [Header("GoldGoals")]
    public List<int> GoalsList;

}
