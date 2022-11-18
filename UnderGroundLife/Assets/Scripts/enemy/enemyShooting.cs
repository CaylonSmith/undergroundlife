using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{


    public float timeBtwshots;
    public float startTimeBtwShots;
    public GameObject projectile;
    public Transform shotPoint;
    [SerializeField] Transform player;
    [SerializeField] float aggroRange;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);


        if (distToPlayer < aggroRange && GameObject.FindGameObjectWithTag("Player") != null)
        {
            print("pp shooting");
            if (timeBtwshots <= 0)
            {
                animator.SetBool("isAttacking", true);
                Instantiate(projectile, shotPoint.position, Quaternion.identity);
                timeBtwshots = startTimeBtwShots;
            }
            else
            {
                timeBtwshots -= Time.deltaTime;
            }

        }
    }
}
