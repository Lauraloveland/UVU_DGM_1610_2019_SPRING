using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour{
public Transform firePoint;
public GameObject projectile;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
            print("shooting");
        }
    }
}
