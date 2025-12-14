using System.Collections;
using TMPro;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public GeneralSettings settings;
    public GameManager gameManager;

    public TextMeshProUGUI Goaltext;
    public  int Goal;
    private int GoalCounter;

    public GameObject WinMessage;
    public GameObject LooseMessage;

    private void Start()
    {
        WinMessage.SetActive(false);
        LooseMessage.SetActive(false);
        Goaltext.text = "Goal : " + settings.GoalsList[0];
        Goal = settings.GoalsList[0];
        GoalCounter = 0;
    }

    private void Update()
    {
        
        Goaltext.text = "Goal : " + Goal;
        if (gameManager.Try == 0 )
        {
            LooseMessage.SetActive(true);
            Time.timeScale = 0;
        }
    }
    


    public void NextGoal ()
    {
        GoalCounter++;
        if (settings.GoalsList.Count > GoalCounter)
        {
            Goal = settings.GoalsList[GoalCounter];
        }
        else
        {
            WinMessage.SetActive (true);
            Time.timeScale = 0;
        }
        
    }




}
