using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public GameObject destroyEffect;
    public int attackDamage;
     int MaxDamage;

    private void Start()
    {

        MaxDamage = attackDamage;


        Invoke("DestroyProjectile", lifeTime);

     
        

    }

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
   



    }


    private void OnTriggerEnter2D(Collider2D enemy)
    {




       if (enemy.CompareTag("enemy"))
        {
            enemy.GetComponent<enemyHealth>().takeDamage(MaxDamage);
        }

       // if (enemy.CompareTag("Player"))
     //   {
    //        enemy.GetComponent<playerHealth>().takeDamage(MaxDamage);
     //   }


    }


    void DestroyProjectile()
    {
        
     Destroy(gameObject);
    }

   

}
