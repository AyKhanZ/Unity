using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public CharacterController2D controller;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false; 

    bool crouch = false; 

    public Animator animator;

    public Rigidbody2D rb;

    public Transform Respawn;

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
            crouch = true;
            animator.SetBool("Crouch", crouch);
        } 
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
            animator.SetBool("Crouch", crouch);
        }
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Respawn")
        {
            transform.position = Respawn.position;
        } 
    }
}
