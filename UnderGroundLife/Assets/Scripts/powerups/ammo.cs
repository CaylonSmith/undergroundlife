using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Player"))
        {



          

            collision.GetComponent<weapon>().allowedShoot = true;
collision.GetComponent<weapon>().shotsLeft = collision.GetComponent<weapon>().maxShots;

            Destroy(gameObject);

        }








    }
}
