using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveBomb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
        
            GameObject.FindGameObjectWithTag("Player").GetComponent<bombMaker>().enabled = true;

            destroyPickup();
        }
    }

    void destroyPickup()
    {

        Destroy(gameObject);
    }
}
