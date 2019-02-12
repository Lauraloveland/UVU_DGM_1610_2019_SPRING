using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{ public float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (Input.GetKey(KeyCode.D))
           GetConmponent<Rigidbody2D>().Velocity
        
    }
}
