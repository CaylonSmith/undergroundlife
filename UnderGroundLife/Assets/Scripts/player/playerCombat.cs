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


  public  bool hasKnife;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        getDamage();


        if (Time.time >= nextTimeAttack)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                useWeapon();
                attack();
                nextTimeAttack = Time.time + 1 / attackRate;
                
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
            //play knife attack animation
        }
        else if (hasKnife == false)
        {
            //play fist animation
        }
    }

    void attack()
    {
     Collider2D[] hitEnemies=   Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
     
            enemy.GetComponent<enemyHealth>().takeDamage(attackDamage);
        }
    }


    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
