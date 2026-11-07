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
        fadeToBlack.FadeAndLoad("Sjofn - Test Scene", 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
