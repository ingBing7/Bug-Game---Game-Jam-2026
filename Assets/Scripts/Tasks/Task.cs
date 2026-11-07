using UnityEngine;

public class Task : MonoBehaviour
{
    public float tasksCompleted;
    public float maxTasksForDay;
    public bool levelOver;

    public void Start()
    {
        Locator.Instance.PackTask.CompletedTask += UpdateOverallTaskCounter;
        Locator.Instance.SportTask.CompletedSportTask += UpdateOverallTaskCounter;
    }

    public void UpdateOverallTaskCounter()
    {
        tasksCompleted++;

        if(tasksCompleted == maxTasksForDay)
        {
            levelOver = true;
            //fade to black, indicates somehow that the player has died.
            Debug.Log("Actions Completed for the day. you DIED!!!!");
        }
    }

}
