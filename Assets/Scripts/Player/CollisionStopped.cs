using Unity.VisualScripting;
using UnityEngine;

public class CollisionStopped : MonoBehaviour
{
    public PlayerMovement playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /*
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            playerMovement.CollisionCheck();
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            playerMovement.CollisionFix();
        }
    }
    */
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            playerMovement.CollisionCheck();
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            playerMovement.CollisionFix();
        }
    }
    
}
