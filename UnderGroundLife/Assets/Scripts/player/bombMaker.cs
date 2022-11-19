using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bombMaker : MonoBehaviour
{

 public  GameObject bomb;
    public int Maxbomb;
    public int currentAmountBombs;

    public TextMeshProUGUI AmmoBombText;
    private float moveInput;
    public int direction;

    Vector3 playerPos;
    Vector3 bombspawn;


    private void Awake()
    {
        currentAmountBombs = Maxbomb;
       
    }
    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        playerPos = transform.position;




        if (Input.GetKeyDown(KeyCode.L))
        {
            if (moveInput < 0)
            {
                direction = 1;


            }
            else if (moveInput > 0)
            {
                direction = 2;



            }
            if (currentAmountBombs>0&&moveInput<0)
            {
                Instantiate(bomb, playerPos += new Vector3(-0.25f, 0, 0), Quaternion.identity);
                currentAmountBombs -= 1;
            }
            else if (currentAmountBombs > 0 && moveInput > 0)
            {
                Instantiate(bomb, playerPos += new Vector3(0.25f, 0, 0), Quaternion.identity);
                currentAmountBombs -= 1;
            }
        }
       

        else
        {
            print("huh");        }
        AmmoBombText.text = currentAmountBombs.ToString();

        
    }



    public void increasebombs(int bombamount)
    {


        if (currentAmountBombs <= 0)
        {
            currentAmountBombs += Maxbomb;
        }
    }
}
