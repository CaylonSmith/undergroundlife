using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveGun : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("gg").GetComponent<gunMonitor>().enabled = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<weapon>().enabled = true;
        





            destroyPickup();

        }
    }

    void destroyPickup()
    {

        Destroy(gameObject);
    }
}
