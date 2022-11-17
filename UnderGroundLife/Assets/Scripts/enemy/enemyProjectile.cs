using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public GameObject destroyEffect;
    public int attackDamage;
    int MaxDamage;


    Transform player;
    Vector2 target;
    private void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);

        MaxDamage = attackDamage;


        Invoke("DestroyProjectile", lifeTime);




    }

    private void Update()
    {
        //  transform.position += transform.right * Time.deltaTime * speed;


        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);


        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }

    }


    private void OnTriggerEnter2D(Collider2D enemy)
    {


        if (enemy.CompareTag("Player"))
        {

            enemy.GetComponent<playerHealth>().takeDamage(MaxDamage);
            DestroyProjectile();
        }

      

    }


    void DestroyProjectile()
    {

        Destroy(gameObject);
    }


}
