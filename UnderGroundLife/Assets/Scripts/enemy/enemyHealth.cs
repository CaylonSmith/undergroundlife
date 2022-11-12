using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    [SerializeField] int currenthealth;


    [SerializeField] Rigidbody2D rb2d;

    private Material whiteMaterial;
    private Material defaultMaterial;
    SpriteRenderer sR;

    private void Start()
    {
        currenthealth = maxHealth;
        rb2d = rb2d = GetComponent<Rigidbody2D>();

        sR = GetComponent<SpriteRenderer>();
        defaultMaterial = sR.material;


    }


    public void takeDamage(int damage)
    {
        currenthealth -= damage;

        if (currenthealth <= 0)
        {
            die();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet_p"))
        {

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
        Destroy(gameObject.GetComponent<enemyShooting>());
        Destroy(gameObject.GetComponent<enemyBomber>());
        


    }
}
