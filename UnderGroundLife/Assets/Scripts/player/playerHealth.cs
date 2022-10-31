using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 200;
    public int currenthealth;


    [SerializeField] Rigidbody2D rb2d;

    private void Start()
    {
        currenthealth = maxHealth;
     
    }


    private void Update()
    {
        rb2d = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }


    public void takeDamage(int damage)
    {
        currenthealth -= damage;

        if (currenthealth <= 0)
        {
            die();
        }
    }

    public void gainHealth(int health)
    {
        currenthealth += health;

      
    }




    private void die()
    {
        Debug.Log("player has died");

        gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        Destroy(gameObject);
        SceneManager.LoadScene(2);
    }
}
