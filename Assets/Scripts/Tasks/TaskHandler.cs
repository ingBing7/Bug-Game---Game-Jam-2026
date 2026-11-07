using UnityEngine;

public class TaskHandler : MonoBehaviour
{
    public delegate void EmptyDelagate();
    public event EmptyDelagate CompletedTask;
    public event EmptyDelagate IncreaseCounter;
    public event EmptyDelagate DecreaseCounter;


    public float objectsPutInBox = 0f;
    public float maxObjectsInBox = 3f;
    public bool actionComplete = false;

    /*
    private void Update()
    {
        if(objectsPutInBox == maxObjectsInBox)
        {
            actionComplete = true;
            CompletedTask?.Invoke();
        }
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("BoxObject"))
        {
            if (objectsPutInBox < maxObjectsInBox && !actionComplete)
            {
                objectsPutInBox++;
                IncreaseCounter?.Invoke();
                if(objectsPutInBox == maxObjectsInBox)
                {
                    actionComplete = true;
                    CompletedTask?.Invoke();
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("BoxObject") && !actionComplete)
        {
            objectsPutInBox--;
            DecreaseCounter?.Invoke();
        }
    }

}
