using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elavatorMovement : MonoBehaviour
{
    public Transform player;
    public Transform downPos;
    public Transform TriggerPos;
    public Transform upperPos;
    public float speed;
    bool isElvdown;
    float dist;
    



    private void Update()
    {
        startElevator();

      dist=  Vector2.Distance(player.position, TriggerPos.position);
      
    }






    

    private void startElevator()
    {
if (dist<1.4f&&Input.GetKeyDown("e"))
        {
          if(  transform.position.y <= downPos.position.y){
                isElvdown = true;
            }

          else if (transform.position.y >= upperPos.position.y)
            {
                isElvdown = false;
            }
        }


 
        if (isElvdown)
        {
            transform.position = Vector2.MoveTowards(transform.position, upperPos.position, speed * Time.deltaTime);
        }
        else if (isElvdown == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, downPos.position, speed * Time.deltaTime);
        }
    }
}
