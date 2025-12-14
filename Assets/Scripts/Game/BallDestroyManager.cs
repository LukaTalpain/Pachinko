using System.Collections;
using UnityEngine;

public class BallDestroyManager : MonoBehaviour
{
    public GameManager gameManager;
    public EnumManager.SlotsType Type;
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Effect(Type);
    }

    private void Effect (EnumManager.SlotsType Type)
    {
        if (Type == EnumManager.SlotsType.Slot0)
        {
            gameManager.EffectBall(0);
            print("ouais ");
        }
        else if (Type == EnumManager.SlotsType.Slot1)
        {
            gameManager.EffectBall(1);
        }
        else if (Type == EnumManager.SlotsType.Slot2)
        {
            gameManager.EffectBall(2);
        }
        else if (Type == EnumManager.SlotsType.Slot3)
        {
            gameManager.EffectBall(3);
        }
        else if (Type == EnumManager.SlotsType.Slot4)
        {
            gameManager.EffectBall(4);
        }
        else if (Type == EnumManager.SlotsType.Slot5)
        {
            gameManager.EffectBall(5);
        }
        
        else if (Type == EnumManager.SlotsType.BonusSlot)
        {
            gameManager.EffectBall(6);
        }
    }

    






}





public class EnumManager  : MonoBehaviour
{
    [System.Serializable]
    public enum SlotsType
    {
        Slot0, Slot1, Slot2, Slot3, Slot4, Slot5, BonusSlot
    }
    [SerializeField] public SlotsType Type;

    [System.Serializable]
    public enum BonusType
    {
        AddMultiplier, AddValueToExtern, AddValueToMid,AddValueToCenter, MoreStartingBalls, AddExternLooseCenter,AddCenterLooseEverywhere
    }
    [SerializeField] public BonusType typeBonus;

}
