using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class gunMonitor : MonoBehaviour
{

    bool hasGun=false;

   public float gunvisibleTimer;
    Vector3 lastMouseCoordinate = Vector3.zero;
    void Update()
    {
       
        Vector3 mouseDelta = Input.mousePosition - lastMouseCoordinate;

        if (mouseDelta.x < 0||mouseDelta.x>0&& hasGun==true)
        {
            print("mosue is moving");


           GameObject.FindGameObjectWithTag("weaponx").GetComponent<SpriteRenderer>().enabled = true;
            gunvisibleTimer = 5;
        }

        else {

            gunvisibleTimer -= Time.deltaTime;


        }

        checkTImer();







        lastMouseCoordinate = Input.mousePosition;
    }



    public void checkTImer()
    {
        if (gunvisibleTimer <= 0)
        {
            GameObject.FindGameObjectWithTag("weaponx").GetComponent<SpriteRenderer>().enabled = false;
            
        }
    }



}
