using UnityEngine;

public class FinalTask : MonoBehaviour
{
    public AudioManager audioManager;
    public Task task;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioManager.TaskCompletedSound();
            task.UpdateOverallTaskCounter();
        }
    }
}
