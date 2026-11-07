using UnityEngine;
using UnityEngine.Rendering;

public class ResetToPhysicsObject : MonoBehaviour
{
    [SerializeField] float distanceFromPlayer;
    public GameObject physicsObject;
    public GameObject player;

    public void Update()
    {
        //uggg finds distance between player
        distanceFromPlayer = Vector3.Distance(player.transform.position, physicsObject.transform.position);
        if(distanceFromPlayer >= 2f)
        {
            gameObject.layer = LayerMask.NameToLayer("Physics Object");

        }
    }
}
