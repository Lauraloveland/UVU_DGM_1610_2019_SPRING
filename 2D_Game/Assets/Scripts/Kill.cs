using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour{
    public LevelManager levelManager;
  void OnTriggerEnter2D(Collider2D other){
      if(other.name == "Player"){
          levelManager.RespawnPlayerCo();
          Destroy(other);

      }
   }
}
