using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckPoint;
    private Rigidbody2D PCRigid;
    private GameObject player;

    // Particles
    public GameObject deathParticle;
    public GameObject respawnParticle;

    // Respawning
    public float RespawnDelay;
    
    // Points penalize when killed
    public int PointPenaltyOnDeath;
    
    // Gravity value 
    private float gravityStore;

    void Start (){
        PCRigid = GameObject.Find("PC").GetComponent<Rigidbody2D>();
     player = GameObject.Find("Player");
    }
        // puclic void  RespawnPlayer(){
        //     StartCor
    //    Next class



    //     }
    // }

