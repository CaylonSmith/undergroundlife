using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_levelSelect : MonoBehaviour
{
    private Rigidbody2D rb2b;
    public GameObject dialogueBox;
    float dist;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        rb2b = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector2.Distance(player.position, transform.position);
        print(dist + "this is how far");

        LevelMenu();
    }




    public void LevelMenu()
    {
        if( dist < 1.4f && Input.GetKeyDown("i"))
        {
            if (dialogueBox.activeSelf)
            {
                dialogueBox.SetActive(false);
            }
            else
            {
                dialogueBox.SetActive(true);
                GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }

        }
        }
    }


