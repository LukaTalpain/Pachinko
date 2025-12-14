using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameManager gameManager;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameManager.ButtonPressed();
        }
    }
}
