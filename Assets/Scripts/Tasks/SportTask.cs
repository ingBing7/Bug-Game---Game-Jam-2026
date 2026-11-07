using UnityEngine;

public class SportTask : MonoBehaviour
{
    public bool ballInZone;

    public AudioManager audioManager;
    public Task task;

    private void OnTriggerEnter(Collider other)
    {
        if(!ballInZone)
        {
            if (other.gameObject.CompareTag("SportBall"))
            {
                ballInZone = true;
                audioManager.TaskCompletedSound();
                task.UpdateOverallTaskCounter();
            }
        }

    }
}
