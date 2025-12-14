using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BonusSettings : ScriptableObject
{
    public List<BonusClass> ListBonus;
}
[System.Serializable]
public class BonusClass
{
    public string BonusEffect;
    public EnumManager.BonusType Type;

}


