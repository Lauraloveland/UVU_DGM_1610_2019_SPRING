using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour{


public string suspect;
public string weapon;

    void Start() 
    {
    
     MurderMystery(suspect);
        
    }
      void Update()
    {
        
    }

void MurderMystery (string person){

      switch(person){

            case "Mr. Ketchup":
        

            print("Im innocent, Ya'll Ugly!");

            break;

            case "Mr. Radish":

            print("I am also innocent");

            break;

            case "Mrs. Fry sauce":

            print("I was on the phone");

            break;

            case "Mrs. Mayo":

            print ("whatever man I gave up Years ago");

            break;

            default:

            print("I am not familiar with "+suspect+"!");
         
            break;

          }

         
          
      }
