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
         puclic void  RespawnPlayer(){
           StartCoroutine ("RespawnPlayerCo");
         }
         public IEnumerator RespawnPlayerCo(){

             Instantiate (deathParticle, PCRigid.transform.position, PCRigid.transform.rotation);

             player.SetActive(false);

             PCRigid.GetComponent<Renderer> ().enabled = false;

             gravityStore = PCRigid.GetComponent<Rigidbody2D>().gravityScale;

             PCRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;

             PCRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

             Scoremanager.AddPoints(-PointPenaltyOnDeath);

             Debug.Log("PC Respawn");

             yield return new WaitForSeconds (RespawnDelay);

             PCRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;

             PCRigid.transform.position = currentCheckPoint.transform.transform.position;

             player.SetActive(true);
             PCRigid.GetComponent<Renderer> ().enabled= true;

             Instantiate (respawnParticle, currentCheckPoint.transform.position,currentCheckPoint.transform.rotation);


         }

         }
   