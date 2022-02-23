using UnityEngine;

public class exitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exiting Game");
    }
}
