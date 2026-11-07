using UnityEngine;
using UnityEngine.Rendering;

public class ResetToPhysicsObject : MonoBehaviour
{
    [SerializeField] float distanceFromPlayer;
    public GameObject physicsObject;
    public GameObject player;
    [SerializeField] bool isGrabbed;

    public void Update()
    {
        //uggg find distance
        distanceFromPlayer = Vector3.Distance(player.transform.position, physicsObject.transform.position);
        if(distanceFromPlayer >= 5f)
        {
            gameObject.layer = LayerMask.NameToLayer("Physics Object");

        }
    }

    public void Start()
    {
        //Locator.Instance.PickUp.GrabbedObject += HasBeenGrabbed;
    }
}
