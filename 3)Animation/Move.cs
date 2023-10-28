using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public CharacterController2D controller;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;

    bool crouch = false;

    bool bit = false;

    public Animator animator;

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetBool("IsGround", controller.m_Grounded);

        animator.SetFloat("velocityY", rb.velocity.y);

        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
            jump = true;
        }


        if (Input.GetButtonDown("Crouch"))
        {
            animator.SetTrigger("Crouch");
            crouch = true;
        }
        if (Input.GetButtonDown("Bit"))
        {
            animator.SetTrigger("Bit");
            bit = true;
        }
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
