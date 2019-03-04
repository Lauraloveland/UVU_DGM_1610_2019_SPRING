using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elseifstatements : MonoBehaviour{

public string noodles;
public bool spicy = true;
public string sauce;
public string beef;
public string broth;
public bool boiled;

    void Start()
    {
      
        if (noodles == "tender"){
            if (spicy){
                print ("The noodles are now done");
        }

          else if (noodles == "soggy" && boiled == true){
              
          }

          print("This is sludge!");{

          }

        else if (noodles == "plain" && spicy == false){
            print ("okay, still gross");

        }
    }


    
    
        
    