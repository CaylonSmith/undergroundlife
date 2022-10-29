using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    [SerializeField] int currenthealth;


    [SerializeField] Rigidbody2D rb2d;

    private void Start()
    {
        currenthealth = maxHealth;
        rb2d = rb2d = GetComponent<Rigidbody2D>();
    }


    public void takeDamage(int damage)
    {
        currenthealth -= damage;

        if (currenthealth <= 0)
        {
            die();
        }
    }

    private void die()
    {
        Debug.Log("enemy has died");

        gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
       Destroy( gameObject.GetComponent<enemyCombat>());
       Destroy( gameObject.GetComponent<enemyMove>());
        Destroy(gameObject.GetComponent<Collider2D>());
        Destroy(gameObject.GetComponent<Animator>());

    }
}
