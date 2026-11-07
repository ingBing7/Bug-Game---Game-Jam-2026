using UnityEngine;

public class PackingTask : MonoBehaviour
{
    // Events
    public AudioManager audioManager;

    public Task task;

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
                    audioManager.TaskCompletedSound();
                    task.UpdateOverallTaskCounter();
                }
                else
                {
                    audioManager.TaskProgressSound();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("BoxObject") && !actionComplete)
        {
            objectsPutInBox--;
            Debug.Log("Object removed from box");
            //figure out something special this does.
        }
    }

}
