using UnityEngine;

public class BallContainerManager : MonoBehaviour
{
    public GameObject BallPrefab;
    

    private float Xcoord = 0;
    public void InstantiateBall ()
    {
        Xcoord = Random.Range(-3f, 3f);
        Vector3 Pos = new Vector3(Xcoord, 4.5f, -2f);
        GameObject FinalBall = Instantiate(BallPrefab, Pos, Quaternion.identity);
        FinalBall.transform.parent = transform;    


    }
}
