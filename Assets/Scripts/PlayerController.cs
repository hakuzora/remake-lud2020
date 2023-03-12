using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float colliderOffset = 0.05f;
    [SerializeField] private GameInput gameInput;
    [SerializeField] private float movSpeed = 2f;

    private Rigidbody2D playerRigidody2D;

    Vector3 movDir;

    
    public bool isWalking;
   /* public bool isUp;
    public bool isRight; */
    
    private void Awake() 
    {
        playerRigidody2D = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {
        //This whole section is for WASD-movement only

        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        movDir = new Vector3(inputVector.x, inputVector.y, 0f);


        isWalking = movDir != Vector3.zero;
        /*isUp = movDir == Vector3.up;
        isRight = movDir == Vector3.right; */

        //This section is for Use button

        if (Input.GetKey(KeyCode.F))
        {

        }

        //This section is for animation of walking

    }

    private void FixedUpdate() 
    {
       playerRigidody2D.MovePosition(transform.position += movDir * movSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Trigger!");
    }

    public bool IsWalking()
    {
        return isWalking;
    }
/*    public bool IsUp()
    {
        return isUp;
    }
    public bool IsRight()
    {
        return isRight;
    } */
}
