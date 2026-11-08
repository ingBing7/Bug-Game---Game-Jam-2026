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

            if(isMotherScene)
            {
                levelOver = true;
                fadeToBlack.FadeAndLoad("TransitionScene 2", 1);
            }

            if(isMotherScene2 == true)
            {
                levelOver = true;
                Debug.Log("IsMother2Scene");
                fadeToBlack.FadeAndLoad("FinalScene", 1);
            }

        }
    }

    public void RemoveCounter()
    {
        tasksCompleted--;
    }

    public void IsMotherScene()
    {
        isMotherScene = true;
    }
    public void IsMother2Scene()
    {
        isMotherScene2 = true;
        Debug.Log("mother2 scene bool set");
    }

}
