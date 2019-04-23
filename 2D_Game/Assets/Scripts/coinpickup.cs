using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinpickup : MonoBehaviour
{

public int coinValue;
void OnTriggerEnter2D(Collider2D other){
    if (other.name == "character"){
            print ("You've Collected The Coin!");



        Scoremanager.AddPoints(coinValue);



            Destroy(gameObject);
        }

    }         

}



