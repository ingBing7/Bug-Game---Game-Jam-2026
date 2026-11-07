using UnityEngine;

public class Task : MonoBehaviour
{
    public float tasksCompleted;
    public float maxTasksForDay;
    public bool levelOver;

    public FadeToBlack fadeToBlack;

    public void UpdateOverallTaskCounter()
    {
        tasksCompleted++;

        if(tasksCompleted == maxTasksForDay)
        {
            levelOver = true;
            //fade to black, indicates somehow that the player has died.
            fadeToBlack.FadeAndLoad("TransitionScene", 1);
        }
    }

}
