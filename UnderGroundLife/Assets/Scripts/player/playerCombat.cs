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


    // Start is called before the first frame update
    void Start()
    {
        attackDamage = 100;
    }

    // Update is called once per frame
    void Update()
    {
       



        if (Time.time >= nextTimeAttack)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {

                attack();
                nextTimeAttack = Time.time + 1 / attackRate;
                
            }
           
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
