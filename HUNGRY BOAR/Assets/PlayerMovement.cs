using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Joystick joystick;
    public Animator animator;

    float horizontalMove = 0f;
    public float runSpeed = 0.2f;

    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {

     

        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; tastiera
        //horizontalMove = joystick.Horizontal * runSpeed; input raw, troppo sensibile
        if (joystick.Horizontal >= .2f)
        {
            horizontalMove = runSpeed;
          
        }
        else if (joystick.Horizontal <= -.2f)
        {
            horizontalMove = -runSpeed;
        }
        else
        {
            horizontalMove = 0f;
        }

        float verticalMove = joystick.Vertical;

        if (verticalMove >= .5f)            //if(Input.GetButtonDown("Jump")
        {
            jump = true;
        }

        if (verticalMove <= -.5f)   // if (Input.GetButtonDown("Crouch")
        {
            crouch = true;
        }
        else   //else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        //move the character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump); //fixedDT: si muove alla stessa velocità, indipendente da quante volte è chiamata fixedUpdate
        jump = false;
    }
}
