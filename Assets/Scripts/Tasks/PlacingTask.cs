using UnityEngine;

public class PlacingTask : MonoBehaviour
{
    public float correctAmountOfObjects;
    public float currentAmountOfObjects;
    public AudioManager audioManager;
    public Task task;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ArtSupply") && currentAmountOfObjects < correctAmountOfObjects)
        {
            currentAmountOfObjects++;

            if(currentAmountOfObjects == correctAmountOfObjects)
            {
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
