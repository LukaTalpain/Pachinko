using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;



    public TextMeshProUGUI ExternValueText;
    public TextMeshProUGUI MidValueText;
    public TextMeshProUGUI CenterValueText;
    public TextMeshProUGUI BonusText;

    public int ExternValue;
    public int MidValue;
    public int CenterValue;
    public int BonusValue;

    public GeneralSettings generalSettings;
    public GameManager gameManager;

    [Header("TriesLeft")]
    public TextMeshProUGUI TryLeftText;
    public GoalManager goalManager;

    private int Score = 0;

    
    private void Start()
    {
        TryLeftText.text = gameManager.Try.ToString();

        Score = 0;
        ExternValue = generalSettings.Slot0_5;
        MidValue = generalSettings.Slot1_4;
        CenterValue = generalSettings.Slot2_3;


        BonusValue = generalSettings.BonusOriginalValue;
    }
    private void Update()
    {
        TryLeftText.text = gameManager.Try.ToString();
        ScoreText.text = "Gold : "+ Score;

        VerifGoal();

        ExternValueText.text = " : " + ExternValue;
        MidValueText.text = " : " + MidValue;
        CenterValueText.text = " : " + CenterValue;

        BonusText.text = " : X" + BonusValue;
    }

    private void VerifGoal ()
    {
        if (Score >= goalManager.Goal)
        {
            goalManager.NextGoal();
            gameManager.RegainTry();
        }
    }

    public void AddScore (int nbr)
    {
        Score += nbr;
    }
    public void RemoveScore (int nbr)
    { 
        Score -= nbr;
    }

}
