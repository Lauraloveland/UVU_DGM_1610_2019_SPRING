 
using UnityEngine;
using System.Collections;
 
public class TestScript : MonoBehaviour
{
    public AnimationCurve myCurve;
   
    void Update()
    {
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
    }
}
//  Heavily referenced from an online unity forum
// This is a test to see if I can animate coins to move up and down