using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    
    private Animator animator;
    private const string IS_WALKING = "IsWalking";
    private const string IS_UP = "IsUp";
    private const string IS_RIGHT = "IsRight";
    [SerializeField] private PlayerController player;

    private void Awake() 
    {
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
       /* animator.SetBool(IS_WALKING, player.IsUp());
        animator.SetBool(IS_WALKING, player.IsRight());*/
    }
}
