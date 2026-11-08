using UnityEngine;

public class UpwardPush : MonoBehaviour
{
    [SerializeField] private float downwardsRayRange = 0.5f;
    [SerializeField] private float pushForce = 3f;
    [SerializeField] Rigidbody playerRB;
    public LayerMask IgnoreMe;


    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, downwardsRayRange, ~IgnoreMe))
        {
            playerRB.AddForce(Vector3.up * pushForce, ForceMode.Force);
            Debug.Log("downray hit");
        }
        */
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, downwardsRayRange, ~IgnoreMe))
        {
            playerRB.AddForce(Vector3.up * pushForce, ForceMode.Force);
            Debug.Log("downray hit");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Vector3 startingPOint = transform.position;
        Vector3 direction = -transform.up * downwardsRayRange;

        Gizmos.DrawRay(startingPOint, direction);
        //this draws a line so I can see where the ray is. 
    }
}
