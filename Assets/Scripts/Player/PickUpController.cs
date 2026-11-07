using UnityEngine;

public class PickUpController : MonoBehaviour
{

    //events 
    //public delegate void EmptyDelagate();
    //public event EmptyDelagate GrabbedObject;

    // layer mask

    public LayerMask IgnoreMe;

    [Header("Pick Up Settings")]
    [SerializeField] Transform holdArea;
    private GameObject heldObject;
    private Rigidbody heldObjectRB;

    [Header("Physics Parameters")]
    [SerializeField] private float pickUpRange = 0.5f;
    [SerializeField] private float pickUpForce = 100f;
    [SerializeField] private float pickUpStiffness = 20f; //higher the number, less bounciness. Lower the number, more bounciness. 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (heldObject == null) //if there is nothing in our hand:
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange, ~IgnoreMe)) // out from the front of the player camera with a range of the esablished pickUpRange.
                {
                    PickUpObject(hit.transform.gameObject); //Triggers PickUpObject method, GameObject found becomes "pickObject" from said method.
                }
            }
            else
            {
                DropObject();
            }
        }

        if (heldObject != null)
        {
            MoveObject();
        }

    }

    void MoveObject()
    {
        if (Vector3.Distance(heldObject.transform.position, holdArea.position) > 0.1f)
        {
            Vector3 moveDirection = (holdArea.position - heldObject.transform.position);
            heldObjectRB.AddForce(moveDirection * pickUpForce);
        }
    }

    void PickUpObject(GameObject pickObject)
    {
        if (pickObject.GetComponent<Rigidbody>())
        {
           // GrabbedObject?.Invoke();
            //Debug.Log("Grabbed " + pickObject.name);
            heldObjectRB = pickObject.GetComponent<Rigidbody>(); //grabs held objects RB
            heldObjectRB.useGravity = false; //prevents held object from falling
            heldObjectRB.linearDamping = pickUpStiffness; //adds a bit of drag to the object 
            heldObjectRB.constraints = RigidbodyConstraints.FreezeRotation; //freezes the rotation of the object.
            pickObject.layer = LayerMask.NameToLayer("IgnoreMe");

            heldObjectRB.transform.parent = holdArea;
            heldObject = pickObject;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Vector3 startingPOint = transform.position;
        Vector3 direction = transform.forward * pickUpRange;

        Gizmos.DrawRay(startingPOint, direction);
    }

    void DropObject()
    {
        //This basically undoes everything PickUpObject does. 
        //I'd like to add some force to throw the object a bit, especially in regards to the rats, but that might make some puzzles a bit harder...
        heldObjectRB.useGravity = true;
        heldObjectRB.linearDamping = 1;
        heldObjectRB.constraints = RigidbodyConstraints.None;
        

        heldObjectRB.transform.parent = null;
        heldObject = null;
    }
}
