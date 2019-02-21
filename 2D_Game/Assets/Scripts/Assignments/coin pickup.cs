using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinpickup : MonoBehaviour
{

public int coinValue;
void OnTriggerEnter2D(Collider2D other){
    if (other.name == "player"){
            print ("You've Collected The Coin!");
            Destroy(gameObject);
        }

    }         

}



