// using System.Collections;
// using UnityEngine;
// public class projectile : MonoBehaviour {
//     public float speed;
//     public float timeOut;
//     public GameObject player;
//     public GameObject enemyDeath;
//     public GameObject projectileParticle;
//     public int pointsForKill;

// }

// void Start(){

//     player = GameObject.Find("Player");

//     enemyDeath = Resources.Load("Prefabs/Death_PS") as GameObject;

// projectileParticle = Resources.Load("Prefabs/Respawn_PS") as GameObject;
// if(PC.Transform.localScale.x < 0)
// Speed = - Speed;

// Destroy(GameObject,timeOut);


// }

// void Update (){
//     GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>()velocity.y);
// }
// void OnTriggerenter2D(Collider2D other ){
    
//     if(other.tag == "Enemy"){
//         Instantiate(enemyDeath. other.Transform.position, other.transform.rotation);
//         Destroy (other.gameObject);
//         Scoremanager.AddPoints (pointsForKill);

//     }
//     Destroy(GameObject);
// }
// void OnCollisionEnter2D(Collision2D other)
// {
    
//         Instantaite(projectileParticle, Transform.position, Transform.rotation);
//         Destroy (GameObject);

//     }
// }

