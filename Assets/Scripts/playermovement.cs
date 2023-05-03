using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    
    public  CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    // public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        // anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        // if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        // {
        //     anim.SetTrigger("move");
        // } else
        // {
        //     anim.Play("Idle");
        // }
        
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButton("Crouch"))
        {
            crouch = true;
            // Debug.Log("Crouch");
        } else
        {
            crouch = false;
        }
        // if (Input.GetButtonDown("Crouch"))
        // {
        //     crouch = true;
        //     Debug.Log("Crouch");
        // } else if (Input.GetButtonUp("Crouch"))
        // {
        //     crouch = false;
        // }
    }

    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
