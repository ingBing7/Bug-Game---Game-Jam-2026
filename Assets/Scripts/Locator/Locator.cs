using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; private set; }
    public PickUpController PickUp { get; private set; }
    public TaskHandler Task {  get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance == this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        GameObject raycastHolder = GameObject.FindWithTag("Raycast Holder");
        GameObject taskZone = GameObject.FindWithTag("Task Zone");

        PickUp = raycastHolder.GetComponent<PickUpController>();
        Task = taskZone.GetComponent<TaskHandler>();
    }
}
