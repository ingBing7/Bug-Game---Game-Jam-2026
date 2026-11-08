using UnityEngine;

public class Task : MonoBehaviour
{
    public float tasksCompleted;
    public float maxTasksForDay;
    public bool levelOver;
    public bool isMotherScene = false;
    public bool isMotherScene2 = false;

    public FadeToBlack fadeToBlack;

    public void UpdateOverallTaskCounter()
    {
        tasksCompleted++;

        if(tasksCompleted == maxTasksForDay)
        {
            if(!isMotherScene)
            {
                levelOver = true;
                fadeToBlack.FadeAndLoad("TransitionScene", 1);
            }
            else if(isMotherScene)
            {
                levelOver = true;
                fadeToBlack.FadeAndLoad("TransitionScene2", 1);
            }
            else if(isMotherScene2)
            {
                levelOver = true;
                fadeToBlack.FadeAndLoad("FinalScene", 1);
            }

        }
    }

    public void IsMotherScene()
    {
        isMotherScene = true;
    }
    public void IsMother2Scene()
    {
        isMotherScene2 = true;
    }

}
