using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    public FadeToBlack fadeToBlack;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void LoadNextScene()
    {
        fadeToBlack.FadeAndLoad("Tutorial", 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
