using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour{
    public LevelManager levelManager;
    void Start (){
        levelManager = FindObjectOfType<LevelManager>();
    }

  void OnTriggerEnter2D(Collider2D other){
      print("entered enemy trigger");
      if(other.tag == "Player"){
          print("killing player");
          levelManager.RespawnPlayer();
          Destroy(gameObject);

      }
   }
}
