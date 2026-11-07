using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; private set; }
    public PickUpController PickUp { get; private set; }
    public PackingTask PackTask {  get; private set; }
    public SportTask SportTask { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance == this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        GameObject raycastHolder = GameObject.FindWithTag("Raycast Holder");
        GameObject packTaskZone = GameObject.FindWithTag("Pack Task Zone");
        GameObject sportTaskZone = GameObject.FindWithTag("Sport Task Zone");

        PickUp = raycastHolder.GetComponent<PickUpController>();
        PackTask = packTaskZone.GetComponent<PackingTask>();
        SportTask = sportTaskZone.GetComponent<SportTask>();
    }
}
