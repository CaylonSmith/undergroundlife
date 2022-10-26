using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Player"))
        {





            GameObject.FindGameObjectWithTag("weapon").GetComponent<weapon>().allowedShoot = true;
                GameObject.FindGameObjectWithTag("weapon").GetComponent<weapon>().shotsLeft = GameObject.FindGameObjectWithTag("weapon").GetComponent<weapon>().maxShots;
                Destroy(gameObject);
          

        }








    }
}
