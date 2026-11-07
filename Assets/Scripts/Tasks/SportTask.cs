using UnityEngine;

public class SportTask : MonoBehaviour
{
    public bool ballInZone;
    public delegate void EmptyDelagate();
    public event EmptyDelagate CompletedSportTask;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!ballInZone)
        {
            if (other.gameObject.CompareTag("SportBall"))
            {
                ballInZone = true;
                CompletedSportTask?.Invoke();
            }
        }

    }
}
