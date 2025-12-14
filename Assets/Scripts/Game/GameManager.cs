using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GeneralSettings Settings;
    public BallContainerManager ballContainerManager;
    public ScoreManager scoreManager;

    public int StartingBallCount;

    public int Try;
    public bool CanSpawn = true;

    private void Start()
    {
        StartingBallCount = Settings.StartingNumberOfBalls;
        Try = Settings.StartingNumberOfBalls;
        CanSpawn = true;
    }
    public void ButtonPressed ()
    {
        if (Try > 0 && CanSpawn)
        {
            Try--;
            SpawnBall();
            
        }
    }

    public void RegainTry ()
    {
        Try += StartingBallCount;
    }

    public void GainTry (int Amount)
    {
        Try += Amount;
    }
    public void LooseTry(int Amount)
    {
        Try -= Amount;
    }


    private void SpawnBall ()
    {
        print("spawn ball");
        ballContainerManager.InstantiateBall();
    }

    public void EffectBall (int Slot)
    {
        if (Slot  == 0 || Slot == 5)
        {
            scoreManager.AddScore(scoreManager.ExternValue);
        }
        else if (Slot == 1 || Slot == 4)
        {
            scoreManager.AddScore(scoreManager.MidValue);
        }
        else if (Slot == 2 || Slot == 3)
        {
            scoreManager.AddScore(scoreManager.CenterValue);
        }
        
        else if (Slot == 6)
        {
            print("bons");
            for (int i = 0; i < scoreManager.BonusValue; i++)
            {
                SpawnBall ();
            }
        }
    }

    public void RestartButton  ()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitButton ()
    {
        SceneManager.LoadScene("Menu");
    }



}
