using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
  
  public Playercontroller player;
  public bool isFollowing;

//   Camera offset
public float xOffset;
public float yOffset;

  
  
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Playercontroller>();
        isFollowing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isFollowing){
            transform.position=new Vector3(player.transform.position.x + xOffset,player.transform.position.y + yOffset, transform.position.z);
        }
    }
}
