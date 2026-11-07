using UnityEngine;

public class UIManager : MonoBehaviour
{

    void Start()
    {
        Locator.Instance.Task.IncreaseCounter += IncreaseCounter;
        Locator.Instance.Task.DecreaseCounter += DecreaseCounter;
        Locator.Instance.Task.CompletedTask += CompletedTask;
    }
    public void IncreaseCounter()
    {
        Debug.Log("Put Object in box");
    }

    public void DecreaseCounter()
    {
        Debug.Log("removed object from box");
    }

    public void CompletedTask()
    {
        Debug.Log("completed the task");
    }
}
