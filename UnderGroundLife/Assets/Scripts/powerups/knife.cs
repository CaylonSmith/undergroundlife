using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour
{





    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<playerCombat>().hasKnife = true;
            Destroy(gameObject);
        }

    }


}
