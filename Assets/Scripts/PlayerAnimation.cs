using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Player player;
    private const string IS_WALKING = "IsWalking";
    private const string DIRECTION_X = "DirectionX";
    private const string  DIRECTION_Y = "DirectionY";
    private Animator animator;


    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        if ((player.DirectionX() != 0) || (player.DirectionY() != 0)) {
            animator.SetBool(IS_WALKING, true);            
            animator.SetFloat(DIRECTION_X, player.DirectionX());
            animator.SetFloat(DIRECTION_Y, player.DirectionY());

        } else {
            animator.SetBool(IS_WALKING, false); 
        }

    }
}

