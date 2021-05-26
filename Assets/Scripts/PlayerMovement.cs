using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        if(Input.GetButtonDown("Jump")){
            jump = true;
            Invoke("TriggerJump", 0.1f);
        }
        if(Input.GetButtonDown("Crouch")){
            crouch = true;
        }else if(Input.GetButtonUp("Crouch")){
            crouch = false;
        }
    }

    void TriggerJump(){
        animator.SetBool("IsJumping", true);
    }
    public void OnLanding(){
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate(){
        //Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        
    }
}
