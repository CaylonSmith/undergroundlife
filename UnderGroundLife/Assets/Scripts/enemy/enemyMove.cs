using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    const string LEFT= "left";
    const string RIGHT = "right";
    

    [SerializeField] Transform castPos;

    [SerializeField] float baseCastDist;


    string facingDirection;

    Vector3 baseScale;

    Rigidbody2D rb2d;
   [SerializeField] float moveSpeed = 5;

    [SerializeField] Transform player;
    [SerializeField] float aggroRange;

  public  bool movingRight;




    // Start is called before the first frame update
    void Start()
    {

        facingDirection = RIGHT;

        baseScale = transform.localScale;
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);


        if (distToPlayer< aggroRange)
        {
            chasePlayer();
        }
        else
        {
            stopChasingPlayer();
        }


        if (movingRight == true)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);



        }

        else if (movingRight == false)
        {
           
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
        




    }

    private void stopChasingPlayer()
    {
     
       
        }


       

 

    private void chasePlayer()
    {


        print("pie");
        float vX = moveSpeed;






        if (transform.position.x < player.position.x)
        {
            movingRight = true;
            rb2d.velocity = new Vector2(vX, rb2d.velocity.y);

            print("eeee");


        }
        else if (transform.position.x > player.position.x)
        {

            movingRight = false;
            rb2d.velocity = new Vector2(-vX, rb2d.velocity.y);
           
        }
    }


    void changeFacingDirection(string newDirection)
    {

        Vector3 newScale = baseScale;

        if (newDirection == LEFT)
        {


            transform.Rotate(0f, 180f, 0f);
        }

        else if (newDirection == RIGHT)
        {
            transform.Rotate(0f, 0f, 0f);
        }

        facingDirection = newDirection;


        print(newDirection);
    }



    private void FixedUpdate()

    {

       


        Debug.Log(facingDirection);

        float vX = moveSpeed;

        if (facingDirection == LEFT)
        {
            vX = -moveSpeed;
        }

        


        if (isHittingWall())
        {
            if (facingDirection == LEFT)
            {
                changeFacingDirection(RIGHT);
            


            }
            else if (facingDirection == RIGHT)
            {
                changeFacingDirection(LEFT);
                

            }
        }




      

     


    }
   




    bool isHittingWall()
        {
            bool val = false;
        float castDist = baseCastDist;
        if (facingDirection==LEFT)
        {
            castDist = -baseCastDist;
           
        }
        else if (facingDirection == RIGHT)

        {
            castDist = baseCastDist;
           
        }



        Vector3 targetPos = castPos.position;
        targetPos.x += castDist;


        Debug.DrawLine(castPos.position, targetPos, Color.blue);


        if (Physics2D.Linecast(castPos.position, targetPos, 1 << LayerMask.NameToLayer("terrain")))
        {
            val = true;
            print("wallll hit");
        }

        else
        {
            val = false;
        }




        return val;
        }

   






}
