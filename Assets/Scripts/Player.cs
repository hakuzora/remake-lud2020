using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    [SerializeField] private GameInput gameInput;
    Rigidbody2D rb = new Rigidbody2D();
    private float moveSpeed = 3.0f;
    public bool isWalking;
    public float directionX;
    public float directionY;


    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate(){
        Vector2 moveDirection = gameInput.GetMovementVector();
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
        
        isWalking = moveDirection != Vector2.zero;
        directionX = moveDirection.x;
        directionY = moveDirection.y;
    }

    private void Update(){

    }

    public float DirectionX(){
        return directionX;
    }

    public float DirectionY(){
        return directionY;
    }

    public bool IsWalking(){
        return isWalking;
    }
}
