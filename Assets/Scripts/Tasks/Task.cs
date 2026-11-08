using UnityEngine;

public class Task : MonoBehaviour
{
    public float tasksCompleted;
    public float maxTasksForDay;
    public bool levelOver;
    public bool isMotherScene = false;
    public bool isMotherScene2 = false;

    public GameObject Counter1;
    public GameObject Counter2;
    public GameObject Counter3;

    public GameObject deactivatedCounter1;
    public GameObject deactivatedCounter2;
    public GameObject deactivatedCounter3;

    public GameObject mainGoober1;
    public GameObject mainGoober2;
    public GameObject mainGoober3;

    //public UIManager uiManager;

    public FadeToBlack fadeToBlack;

    public void Start()
    {
        Counter1.SetActive(true);
        Counter2.SetActive(true);
        Counter3.SetActive(true);

        deactivatedCounter1.SetActive(false);
        deactivatedCounter2.SetActive(false);
        deactivatedCounter3.SetActive(false);

        mainGoober1.SetActive(true);
        mainGoober2.SetActive(false);
        mainGoober3.SetActive(false);
    }

    public void UpdateOverallTaskCounter()
    {
        tasksCompleted++;
        //uiManager.CompletedTask();

        if(tasksCompleted == 3)
        {
            Counter1.SetActive(false);
            Counter2.SetActive(false);
            Counter3.SetActive(false);

            deactivatedCounter1.SetActive(true);
            deactivatedCounter2.SetActive(true);
            deactivatedCounter3.SetActive(true);

            mainGoober1.SetActive(false);
            mainGoober2.SetActive(false);
            mainGoober3.SetActive(true);
        }
        if(tasksCompleted == 2)
        {
            Counter1.SetActive(true);
            Counter2.SetActive(false);
            Counter3.SetActive(false);

            deactivatedCounter1.SetActive(false);
            deactivatedCounter2.SetActive(true);
            deactivatedCounter3.SetActive(true);

            mainGoober1.SetActive(false);
            mainGoober2.SetActive(true);
            mainGoober3.SetActive(false);
        }
        if (tasksCompleted == 1)
        {
            Counter1.SetActive(true);
            Counter2.SetActive(true);
            Counter3.SetActive(false);

            deactivatedCounter1.SetActive(false);
            deactivatedCounter2.SetActive(false);
            deactivatedCounter3.SetActive(true);

            mainGoober1.SetActive(false);
            mainGoober2.SetActive(true);
            mainGoober3.SetActive(false);
        }
        if(tasksCompleted == 0)
        {
            Counter1.SetActive(true);
            Counter2.SetActive(true);
            Counter3.SetActive(true);

            deactivatedCounter1.SetActive(false);
            deactivatedCounter2.SetActive(false);
            deactivatedCounter3.SetActive(false);

            mainGoober1.SetActive(true);
            mainGoober2.SetActive(false);
            mainGoober3.SetActive(false);
        }

        if (tasksCompleted == maxTasksForDay)
        {
            if(!isMotherScene)
            {
                levelOver = true;
                Debug.Log("istut");
                fadeToBlack.FadeAndLoad("TransitionScene", 1);
            }

            if(isMotherScene)
            {
                levelOver = true;
                Debug.Log("is regular mom");
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
        //uiManager.DecreaseCounter();
    }

    public void IsMotherScene()
    {
        isMotherScene = true;
        Debug.Log("is regular mom");
    }
    public void IsMother2Scene()
    {
        isMotherScene2 = true;
        Debug.Log("mother2 scene bool set");
    }

}
