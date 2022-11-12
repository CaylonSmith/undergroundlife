using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBomber : MonoBehaviour
{

    public float areaOfEffect;
    public LayerMask whatIsDestructible;
    public int damage;
    public int maxDamage = 35;
    public float timer;
    public GameObject effect;



  



    private void Awake()
    {
        damage = maxDamage;

    }


    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {


            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(transform.position, areaOfEffect, whatIsDestructible);
            foreach (Collider2D enemy in enemiesToDamage)
            {


                enemy.GetComponent<playerHealth>().takeDamage(damage);


            }

            Destroy(gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);
        }
        else
        {
            timer -= Time.deltaTime;
            print("minus time");
        }
    }



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, areaOfEffect);
    }



}
