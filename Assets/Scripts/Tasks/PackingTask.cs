using UnityEngine;

public class PackingTask : MonoBehaviour
{
    // Events
    public delegate void EmptyDelagate();
    public event EmptyDelagate CompletedTask;
    public event EmptyDelagate IncreaseCounter;
    public event EmptyDelagate DecreaseCounter;

    public float objectsPutInBox = 0f;
    public float maxObjectsInBox = 3f;
    public bool actionComplete = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BoxObject"))
        {
            if (objectsPutInBox < maxObjectsInBox && !actionComplete)
            {
                objectsPutInBox++;

                if (objectsPutInBox == maxObjectsInBox)
                {
                    actionComplete = true;
                    CompletedTask?.Invoke();
                }
                else
                {
                    IncreaseCounter?.Invoke();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("BoxObject") && !actionComplete)
        {
            objectsPutInBox--;
            DecreaseCounter?.Invoke();
        }
    }

}
