using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour

//player movement variables
{ public float moveSpeed;
public float jumpHeight;

//Player grounded Variables
private bool grounded;
public Transform groundCheck;
public float groundCheckRadius;
public LayerMask whatIsGround;
public Animator Animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }
void FixedUpdate(){
    grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

}
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
            Animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.D)){
            Animator.SetBool("isWalking", false);

        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
            Animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp (KeyCode.A)){
            Animator.SetBool("isWalking", false);
        }

         if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveSpeed);
        }

       if(grounded){
            // doubleJump = false;
            // Animator.SetBool("isJumping", false);
       }

        // player jump
        if(Input.GetKeyDown(KeyCode.W)&& grounded){
            Jump ();
            

        }
    }
           
        public void Jump(){
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
            Animator.SetBool("isJumping", true);
        }
    
}
