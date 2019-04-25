//  using UnityEngine;
//  using System.Collections;
 
//  public class MovingPlatforms : MonoBehaviour {
 
//      public Transform movingPlatform;
//      public Transform position1;
//      public Transform position2;
//      public Vector3 newPosition;
//      public string currentState;
//      public float smooth;
//      public float resetTime;
 
//      // Use this for initialization
//      void Start () {

//          ChangeTarget();
//      }
     
//      // Update is called once per frame
//      void FixedUpdate () {
//          movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPosition, smooth * Time.deltaTime);
//      }
 
//      void ChangeTarget () {
//          if(currentState == "Moving To Position 1")
//          {
//              currentState = "Moving To Position 2";
//              newPosition = position2.position;
//          }
//          else if (currentState == "Moving To Position 2")
//          {
//              currentState = "Moving To Position 1";
//              newPosition = position1.position;
//          }
//          else if (currentState == "")
//          {
//              currentState = "Moving To Position 2";
//              newPosition = position2.position;
//          }
//          Invoke ("ChangeTarget", resetTime);
//      }
//  }



// // This script was heavily refeerenced from a youtube video that can be found here:
// // https://www.youtube.com/watch?v=AfwmRYQRsbg
// // I also received help from my older brother who is a CS major, hope this is okay