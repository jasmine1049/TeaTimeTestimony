using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimationController : MonoBehaviour
{
    [SerializeField] Animator MC_Animator;
    Vector3 currentDirection = new Vector3(0f, 0f, 0f);

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 newDirection = new Vector3(horizontal, 0f, vertical);

        //when moving diagonally, favor the direction of the first key pressed.
        if((currentDirection.x != 0 && currentDirection.x == horizontal) || (currentDirection.z != 0 && currentDirection.z == vertical))
        {
            return;
        }

        currentDirection = newDirection;

        MC_Animator.SetFloat("vertical", vertical);
        MC_Animator.SetFloat("horizontal", horizontal);
        
        if(vertical == 0 && horizontal == 0)
        {
            Debug.Log("Still");
            MC_Animator.SetTrigger("idle");
        }
    }
}
