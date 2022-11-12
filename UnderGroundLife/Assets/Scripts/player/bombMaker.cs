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

    public TextMeshProUGUI MaxAmmoBombText;




    private void Awake()
    {
        currentAmountBombs = Maxbomb;
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


        AmmoBombText.text = currentAmountBombs.ToString();

        MaxAmmoBombText.text = Maxbomb.ToString();
        
    }



    public void increasebombs(int bombamount)
    {


        if (currentAmountBombs <= 0)
        {
            currentAmountBombs += Maxbomb;
        }
    }
}
