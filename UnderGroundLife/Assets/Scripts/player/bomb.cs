using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
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


        {
          
                if (timer <= 0)
                {
                    Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(transform.position, areaOfEffect, whatIsDestructible);
                    foreach (Collider2D enemy in enemiesToDamage)
                    {


                        enemy.GetComponent<enemyHealth>().takeDamage(damage);
                      

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
        }
    

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, areaOfEffect);
    }



   
}
