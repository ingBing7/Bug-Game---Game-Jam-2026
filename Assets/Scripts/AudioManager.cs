using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource throwSound;
    public AudioSource dropSound;
    public AudioSource grabSound;
    public AudioSource taskProgressSound;
    public AudioSource taskCompletedSound;

    void Start()
    {
        //Pick Up Events
        Locator.Instance.PickUp.GrabbedObject += GrabbedObjectSound;
        Locator.Instance.PickUp.DroppedObject += DroppedObjectSound;
        Locator.Instance.PickUp.ThrewObject += ThrowObjectSound;

        // Task Events 
        Locator.Instance.PackTask.CompletedTask += TaskCompletedSound;
        Locator.Instance.PackTask.IncreaseCounter += TaskProgressSound;
        Locator.Instance.SportTask.CompletedSportTask += TaskCompletedSound;
    }

    public void ThrowObjectSound()
    {
        throwSound.Play();
    }

    public void DroppedObjectSound()
    {
        dropSound.Play();
    }

    public void GrabbedObjectSound()
    {
        grabSound.Play();
    }

    public void TaskProgressSound()
    {
        taskProgressSound.Play();
    }

    public void TaskCompletedSound()
    {
        taskCompletedSound.Play();
    }

}
