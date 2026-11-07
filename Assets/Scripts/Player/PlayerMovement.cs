using UnityEngine;
using static PlayerMovement;

public class PlayerMovement : MonoBehaviour
{
    /*
    public enum CharacterStates
    {
        InAir,
        Grounded
    }
    //State Machine
    [SerializeField] CharacterStates currentState;
    */

    [Header("References")]
    [SerializeField] Rigidbody playerRB;

    [Header("Movement Variables")]
    [SerializeField] float moveSpeed;
    [SerializeField] float maxFloatHeight = 10f;
    [SerializeField] float minFloatHeight;
    [SerializeField] Camera freeLookCamera;
    [SerializeField] float currentHeight;
    [SerializeField] float xRotation;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        //currentState = CharacterStates.Grounded;
        currentHeight = transform.position.y;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        xRotation = freeLookCamera.transform.rotation.eulerAngles.x;
        /*
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        
        if(currentState == CharacterStates.InAir)
        {
            playerRB.useGravity = false;
        }
        else if(currentState == CharacterStates.InAir)
        {
            playerRB.useGravity = true;
        }
        */

        //make state exclusive

        if(Input.GetKey(KeyCode.W))
        {
            FlyingLogic();
        }
        else
        {
            StopFlying();
        }

        currentHeight = Mathf.Clamp(transform.position.y, currentHeight, maxFloatHeight);
        //transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        playerRB.MovePosition(new Vector3(transform.position.x, currentHeight, transform.position.z));
    }

    private void FlyingLogic()
    {
        Vector3 cameraForward = new Vector3(freeLookCamera.transform.forward.x, freeLookCamera.transform.forward.y, freeLookCamera.transform.forward.z);
        transform.rotation = Quaternion.LookRotation(cameraForward);
        transform.Rotate(new Vector3(0, 0, 0), Space.Self);

        Vector3 forward = freeLookCamera.transform.forward;
        Vector3 flyDirection = forward.normalized;

        currentHeight += flyDirection.y * moveSpeed * Time.deltaTime;
        currentHeight = Mathf.Clamp(currentHeight, minFloatHeight, maxFloatHeight);

        transform.position += flyDirection * moveSpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
        playerRB.constraints = RigidbodyConstraints.None;
    }

    private void StopFlying()
    {
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
        playerRB.constraints = RigidbodyConstraints.FreezePosition;
    }
}

//tutorial followed: https://www.youtube.com/watch?v=8_49VvqssMU
//make sure to use capsule collider it does NOT work with a box collider. Makes 
