using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombMaker : MonoBehaviour
{

 public  GameObject bomb;
    public int Maxbomb;
    public int currentAmountBombs;




    private void Awake()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (currentAmountBombs>0)
            {
                Instantiate(bomb, transform.position, Quaternion.identity);
                currentAmountBombs -= 1;
            }
        }
        else
        {
            print("bombs cannot be spawned");
        }
        
    }



    public void increasebombs(int bombamount)
    {


        if (currentAmountBombs <= 0)
        {
            currentAmountBombs += Maxbomb;
        }
    }
}
