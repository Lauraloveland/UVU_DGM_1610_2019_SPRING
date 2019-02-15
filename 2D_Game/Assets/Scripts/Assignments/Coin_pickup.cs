using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_pickup : Pickup {
    
      public GameObject PC;


     void OnTriggerEnter2D(Collider2D other)
     {
     
         if (other.name == "PC")
         {
             //player Collects coin
         }

       else
       {
           //Not player
       }
     }
    // Start is called before the first frame update
    void Start()
    {
        //inside of the container
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
