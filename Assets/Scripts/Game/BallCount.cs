using UnityEngine;

public class BallCount : MonoBehaviour
{
    

    private void Awake()
    {
        GoalManager.TotalBall += 1;

    }

    private void OnDestroy()
    {
        GoalManager.TotalBall -= 1;
    }
}
