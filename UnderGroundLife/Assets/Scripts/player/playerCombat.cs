using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCombat : MonoBehaviour
{


    [SerializeField] Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage;
    public float attackRate = 1f;
    float nextTimeAttack = 0f;
    public Animator animator;


    bool isGunning;




    public  bool hasKnife;


    private void Awake()
    {
        GameObject.FindGameObjectWithTag("weaponx").GetComponent<SpriteRenderer>().enabled = false;

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


        Gunning();
        getDamage();


        if (Time.time >= nextTimeAttack)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {




                useWeapon();

                attack();
                nextTimeAttack = Time.time + 1 / attackRate;


            }
            else
            {
                animator.SetBool("isAttacking", false);
            }
           
        }

    }

    private void getDamage()
    {
        if (hasKnife == true)
        {
            attackDamage = 100;
        }
        else if(hasKnife==false)
        {
            attackDamage = 50;
        }
    }


    private void useWeapon()
    {
        if (hasKnife == true)
        {
            isGunning = true;
        }
        else if (hasKnife == false)
        {
            //play fist animation
        }
    }

    void attack()
    {

       


          

            animator.SetBool("isAttacking", true);
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnemies)
            {


                enemy.GetComponent<enemyHealth>().takeDamage(attackDamage);

            }
        


    }



    void Gunning()
    {
        if (isGunning == true)
        {
          
        }
        else
        {

        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
