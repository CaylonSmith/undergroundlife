using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class gunMonitor : MonoBehaviour
{

    bool hasGun=false;
    Vector3 lastMouseCoordinate = Vector3.zero;
    void Update()
    {
       
        Vector3 mouseDelta = Input.mousePosition - lastMouseCoordinate;

        if (mouseDelta.x < 0||mouseDelta.x>0&& hasGun==true)
        {
            print("mosue is moving");

           GameObject.FindGameObjectWithTag("weaponx").GetComponent<SpriteRenderer>().enabled = true;
        }

        else {
           
        
        }
      

        lastMouseCoordinate = Input.mousePosition;
    }
}
