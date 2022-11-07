using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class dialogue : MonoBehaviour
{
   public GameObject dialogueBox;
    public TMP_Text popUpText;
    private Rigidbody2D rb2b;
    bool inDialogue;



    private void Start()
    {
        rb2b = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            dialogueBox.SetActive(true);
            inDialogue = true;

        }
    }


    private void Update()
    {
        if (inDialogue == true)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        else
        {
            inDialogue = false;
        }
    }
    
  




    public void uiProgress()
    {
        Destroy(dialogueBox);

        inDialogue = false;
    }
}
