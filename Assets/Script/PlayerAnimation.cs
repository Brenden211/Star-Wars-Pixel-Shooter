using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (playerMovement.moveDirection == -1)
        {
            animator.SetInteger("MoveDirection", -1);
        }
        else if (playerMovement.moveDirection == 1)
        {
            animator.SetInteger("MoveDirection", 1);
        }
        else
        {
            animator.SetInteger("MoveDirection", 0);
        }
    }
}
