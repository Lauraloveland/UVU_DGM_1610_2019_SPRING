﻿// using UnityEngine;
//  using System.Collections;
 
//  public class Punchingscript : MonoBehaviour {
 
//      private bool punching = false;
     
//      void Update() {
//          if (!punching && Input.GetKeyDown(KeyCode.Space)) {
//              StartCoroutine(Punch(0.5f, 1.25f, transform.forward));
//          }
//      }
     
//      IEnumerator Punch(float time, float distance, Vector3 direction) {
//          punching = true;
//          var timer = 0.0f;
//          var orgPos = transform.position;
//          direction.Normalize();
//          Debug.Log("Above the loop");
//          while (timer <= time) {
//              Debug.Log("----");
//              transform.position = orgPos + (Mathf.Sin(timer / time * Mathf.PI) + 1.0f) * direction;
//              yield return null;
//              timer += Time.deltaTime;
//          }
//          transform.position = orgPos;
//          punching = false;
//      }
//  }

// //  Heavily Referenced from a Unity Forum