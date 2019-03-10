using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifstatements : MonoBehaviour{
public string stopLight;
public string trafficCones;
public bool isUtahn = true; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

                    
    void Update(){

     if(stopLight== "Red" && isUtahn){
         print("stop! The light is red!");
     }


else if(stopLight== "Yellow"){ 
    if(isUtahn)
        print("hurry!!!");
    }
else if(stopLight== "Green"){ 
    if(isUtahn)
        print("Slam the breaks just for fun");
  }
  else{
      print("Thanks for driving like a normie");
    
  }


}
}