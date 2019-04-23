using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour

//player movement variables
{ public float moveSpeed;
public float jumpHeight;
private bool doubleJump;

//Player grounded Variables
private bool grounded;
public Transform groundCheck;
public float groundCheckRadius;
public LayerMask whatIsGround;


// Non slide player
private float moveVelocity;
public Animator Animator;

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }
void FixedUpdate(){
    grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

}
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            // GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
            moveVelocity = moveSpeed;
            Animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.D)){
            Animator.SetBool("isWalking", false);

        }

        if (Input.GetKey(KeyCode.A))
        {
            // GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
            moveVelocity = - moveSpeed;
            
            Animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp (KeyCode.A)){
            Animator.SetBool("isWalking", false);
        }

		if(Input.GetKeyDown (KeyCode.Space) && grounded){
			Jump();		
            doubleJump = false;
            print("Jumping once");
		}

		// Double jump code
		if(grounded){
			doubleJump = false;	
			Animator.SetBool("isJumping", false);
		}			
			
		if(Input.GetKeyDown (KeyCode.Space) && !doubleJump && !grounded){
			Jump();
			doubleJump = true;		
            print("Jumping twice");	
		}

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        moveVelocity = 0f;
    }
          
        public void Jump(){
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            Animator.SetBool("isJumping", true);
        }
    
}
