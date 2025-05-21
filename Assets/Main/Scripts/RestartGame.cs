using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public string firstLevelName = "Level_1";

    public void RestartTheGame()
    {
        SceneManager.LoadScene(firstLevelName);
    }
}