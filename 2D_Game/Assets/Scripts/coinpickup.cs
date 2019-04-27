using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinpickup : MonoBehaviour
{

public int coinValue;
void OnTriggerEnter2D(Collider2D other){
    if (other.tag == "Player"){
            print ("You've Collected The Coin!");



        ScoreManager.AddPoints(coinValue);



            Destroy(gameObject);
        }

    }         

}



