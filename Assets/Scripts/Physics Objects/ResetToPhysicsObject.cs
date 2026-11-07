using UnityEngine;
using UnityEngine.Rendering;

public class ResetToPhysicsObject : MonoBehaviour
{
    [SerializeField] float distanceFromPlayer;
    [SerializeField] bool isGrabbed;

    private void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.CompareTag("Ground"))
        {
            gameObject.layer = LayerMask.NameToLayer("Physics Object");

        }
        
    }

    public void Update()
    {
        ///uggg find distance
    }

    public void Start()
    {
        //Locator.Instance.PickUp.GrabbedObject += HasBeenGrabbed;
    }
}
