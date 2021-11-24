using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class playerController : MonoBehaviour

{

    private CharacterController _controller;



    [SerializeField]

    private float _gravity = 5f; //gravity



    [SerializeField]

    private float _moveSpeed; //move speed 

    [SerializeField]

    private float sprintSpeed;//sprint speed


    [SerializeField]

    private float _jumpSpeed = 5f;//jump height 

    private float currentSpeed;//current speed 

    private float _directionYtemp;//temp var for jump 



    Animator anim;


    private void Start()

    {

        currentSpeed = _moveSpeed; //set player speed 

        anim = GetComponent<Animator>(); //get animator 

        Cursor.visible = true; //make cursor invisable 
        Screen.lockCursor = false;//lock cursor 

        _controller = GetComponent<CharacterController>(); //gets character controller from player  

    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")//if player collides 
        {

            anim.SetTrigger("Jump");
        }

    }




    void Update()

    {



        float horizontalInput = Input.GetAxis("Horizontal"); //get horizontal input 

        float verticalInput = Input.GetAxis("Vertical"); //get vertical input 



        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput).normalized; //gets look direction  


        //if walking play animation
        if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0 || Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            anim.SetBool("Walk", true);
        }
        else {
            anim.SetBool("Walk", false);
                }



        _directionYtemp -= _gravity * Time.deltaTime; //adds gravity  

        direction.y = _directionYtemp;// sets y direction to the temp value 

        if (_controller.isGrounded) //checks if controlelr is grounded 

        {

           
            /*
            if (Input.GetButtonDown("Jump")) //Jump 
            {
                anim.SetTrigger("jumpStart");

                anim.SetTrigger("Jump");
                _directionYtemp = _jumpSpeed;//set direction y temp to jump speed 
                

                anim.SetTrigger("jumpEnd");
            }
            */

        //game dosnt require jump however the option is here if needed 


            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
               
                //spint 
                if ((Input.GetKey(KeyCode.LeftShift)))//if sprinting 
                {
                    anim.SetBool("Sprint", true);//play sprint animation 
                    currentSpeed = sprintSpeed;//set speed to sprint speed 
                   

                }
                else {
                    anim.SetBool("Sprint", false);//stop playing sprint anim
                    currentSpeed = _moveSpeed; //set speed to notmal 
                }
            }

           


        }
   
        _controller.Move(direction * currentSpeed * Time.deltaTime);//moves player 

    }
}