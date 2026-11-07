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

        PickUp = raycastHolder.GetComponent<PickUpController>();
    }
}
