using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch;
    public bool holding = false;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        

        if (Input.GetButtonDown("Jump") && holding == false) {
            jump = true;
            animator.SetBool("isJumping", true);
        }

        if (Input.GetButtonDown("Crouch") && holding == false) {
            crouch = true;
            animator.SetBool("isCrouching", true);
        }
         else if (Input.GetButtonUp("Crouch")) {
            crouch = false;
            animator.SetBool("isCrouching", false);
        }

    }

    public void OnLanding() {
        animator.SetBool("isJumping", false);
    }

    void FixedUpdate() {
        //Move our char   

        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
