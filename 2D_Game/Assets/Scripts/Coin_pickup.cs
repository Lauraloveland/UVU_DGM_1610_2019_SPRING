using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_pickup : Pickup {
    
      public GameObject PC;


     void OnTriggerEnter2D(Collider2D other){
     
         if (other.name == "PC"){
         
           //player Collects coin

 }
    else {
        //not the player 
    }
    
    
     }

void start (){

}


void update (){

}


}
