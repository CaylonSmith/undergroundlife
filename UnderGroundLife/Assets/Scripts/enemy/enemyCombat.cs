using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCombat : MonoBehaviour
{

    [SerializeField] Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask playerLayers;
    public int attackDamage ;
    public float attackRate = 1f;
    float nextTimeAttack = 0f;
    public Animator animator;
    bool fighting;


    // Start is called before the first frame update
    void Start()
    {
        attackDamage = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeAttack)
        {
           
            attack();
            nextTimeAttack = Time.time + 1 / attackRate;
      


        }

    





    }




    void attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);

        foreach (Collider2D player in hitEnemies)
        {
            fighting = true;
            animator.SetBool("isAttacking", true);
            player.GetComponent<playerHealth>().takeDamage(attackDamage);
        }
      
    }


    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }



   
}
