using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;

public class BonusManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public BonusSettings bonusSettings;
    public List<GameObject> Bonus;

    public GameManager gameManager;

    public GameObject MessageWindow;

    private List<int> ActualBonusList = new List<int>();

    public List<TextMeshProUGUI> BonusEffectText;

    private void Start()
    {
        
        MessageWindow.SetActive(false);
        for (int i = 0; i < Bonus.Count; i++)
        {
            Bonus[i].SetActive(false);
        }
        SpawnBonus();
    }

    private void SpawnBonus()
    {
        StartCoroutine(SpawnBonusTime(6f));
    }

    private IEnumerator SpawnBonusTime (float Time)
    {
        yield return new WaitForSeconds(Time);
        int j = Random.Range(0, Bonus.Count);
        Bonus[j].SetActive(true);
    }

    public void BonusObtained()
    {
        SelectBonus();
        SetUiMessage();
        
        MessageWindow.SetActive(true);
        gameManager.CanSpawn = false;
        Time.timeScale = 0;
        

    }
    private void SelectBonus ()
    {
        ActualBonusList.Clear();
        print("clear : " + ActualBonusList.Count);
        for (int i = 0;i < 3;i++)
        {
            ActualBonusList.Add(Random.Range(0, bonusSettings.ListBonus.Count));
            print(i + " list : " + ActualBonusList[i]);
        }
    }

    private void SetUiMessage()
    {
        for (int i = 0; i < 3; i++)
        {
            BonusEffectText[i].text = bonusSettings.ListBonus[ActualBonusList[i]].BonusEffect;
        }
    }


    public void BonusButton (int num)
    {
        //appliquer l'effet
        if (num == 0)
        {
            ActivEffect(ActualBonusList[0]);
        }
        else if (num == 1)
        {
            ActivEffect(ActualBonusList[1]);
        }
        else if (num == 2)
        {
            ActivEffect(ActualBonusList[2]);
        }
        


        Time.timeScale = 1;
        MessageWindow.SetActive(false);
        gameManager.CanSpawn = true;
        SpawnBonus();
    }


    private void ActivEffect (int i)
    {
        if (bonusSettings.ListBonus[i].Type == EnumManager.BonusType.AddValueToCenter)
        {
        
            scoreManager.CenterValue += 5;
        }


        else if (bonusSettings.ListBonus[i].Type == EnumManager.BonusType.AddValueToMid)
        {
            scoreManager.MidValue += 5;
        }
        else if (bonusSettings.ListBonus[i].Type == EnumManager.BonusType.AddValueToExtern)
        {
            scoreManager.ExternValue += 5;
        }


        else if (bonusSettings.ListBonus[i].Type == EnumManager.BonusType.AddMultiplier)
        {
            scoreManager.BonusValue += 1;
        }
        else if (bonusSettings.ListBonus[i].Type == EnumManager.BonusType.MoreStartingBalls)
        {
            gameManager.StartingBallCount += 5;
        }


        else if (bonusSettings.ListBonus[i].Type == EnumManager.BonusType.AddExternLooseCenter)
        {
            scoreManager.ExternValue += 10;
            scoreManager.CenterValue -= 5;
        }
        else if (bonusSettings.ListBonus[i].Type == EnumManager.BonusType.AddCenterLooseEverywhere)
        {
            scoreManager.ExternValue -= 5;
            scoreManager.CenterValue += 10;
        }
    }

}
