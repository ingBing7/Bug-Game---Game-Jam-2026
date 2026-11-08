using UnityEngine;

public class TransitionSceneManager : MonoBehaviour
{
    public FadeToBlack fadeToBlack;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void LoadNextScene()
    {
        fadeToBlack.FadeAndLoad("Gameplay_Mother", 1);
    }

    public void LoadFinalScene()
    {
        fadeToBlack.FadeAndLoad("Gameplay_2", 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
