﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public CharacterController2D controller;

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

        if (Input.GetButtonDown("Jump") && holding == false) {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch") && holding == false) {
            crouch = true;
        }
         else if (Input.GetButtonUp("Crouch")) {
            crouch = false;
        }

    }

    void FixedUpdate() {
        //Move our char   

        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}