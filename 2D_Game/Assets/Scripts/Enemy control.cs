using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontrol : MonoBehaviour
{
public float moveSpeed;
public bool MoveRight;
// Wallcheck 
public Transform wallCheck;
public float wallCheckRadius;
public LayerMask whatIsWall;
private bool HittingWall;
// edge check
private bool notAtEdge;
public Transform edgeCheck;



    // Update is called once per frame
    void Update()
    {
        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);
        HittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
        if (HittingWall || !notAtEdge){

        }
       if (MoveRight){
           transform.localScale = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
       }
       else{
           transform.localScale = new Vector3(0.2f, 0.2f, 1f);
           GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
       }
    }
}
