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
    public Transform level1Pos;
    public Transform level2Pos;
    public Transform level3Pos;
    public Transform mainElevator;
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






    public void level1()
    {

        if (dist < 1.4f)
        {
            mainElevator.transform.position = Vector2.MoveTowards(transform.position, level1Pos.position, speed * Time.deltaTime);
        }
    } 
    
    public void level2()
    {
        if (dist < 1.4f)
        {
            mainElevator.transform.position = Vector2.MoveTowards(transform.position, level2Pos.position, speed * Time.deltaTime);
        }
    } 
    
    
    public void level3()
    {
        if (dist < 1.4f)
        {
            mainElevator.transform.position = Vector2.MoveTowards(transform.position, level3Pos.position, speed * Time.deltaTime);
        }
    }
}
