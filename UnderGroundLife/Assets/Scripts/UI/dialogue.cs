using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class dialogue : MonoBehaviour
{
   public GameObject dialogueBox;
    public TMP_Text popUpText;




    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            dialogueBox.SetActive(true);

        }
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(dialogueBox);
           // dialogueBox.SetActive(false);
        }
    }
}
