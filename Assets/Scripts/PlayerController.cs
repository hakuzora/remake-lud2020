using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float increaseSpeed = 1f;
    [SerializeField] float movSpeed = 5f;
    public bool isWalking;
    public bool isUp;
    public bool isRight;
    

    void Update()
    {
        //This whole section is for WASD-movement only
        
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y += +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y += -1;            
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x += -1;            
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x += +1;            
        }

        //This section is for SpeedUp button

        if (Input.GetKey(KeyCode.LeftShift))
        {
            increaseSpeed = 3f;
        }
        else
        {
            increaseSpeed = 1f;            
        }
        
        inputVector = inputVector.normalized;

        Vector3 movDir = new Vector3(inputVector.x, inputVector.y, 0f);
        transform.position += movDir * movSpeed * increaseSpeed * Time.deltaTime;

        isWalking = movDir != Vector3.zero;
        isUp = movDir == Vector3.up;
        isRight = movDir == Vector3.right;

        //This section is for Use button

        if (Input.GetKey(KeyCode.F))
        {

        }

        //This section is for animation of walking

    }

    public bool IsWalking()
    {
        return isWalking;
    }
    public bool IsUp()
    {
        return isUp;
    }
    public bool IsRight()
    {
        return isRight;
    }
}
