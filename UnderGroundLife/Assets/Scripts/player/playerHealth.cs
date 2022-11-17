using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[ExecuteInEditMode()]
public class playerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currenthealth;

    public Image bar;



    [SerializeField] Rigidbody2D rb2d;

    manager_checkPoint _cMan;



    private void Awake()
    {
       
    }
    private void Start()
    {
        currenthealth = maxHealth;
        _cMan = GameObject.FindGameObjectWithTag("cMan").GetComponent<manager_checkPoint>();

    }


    private void Update()
    {
        rb2d = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        getcurrentFill(); 
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
        if (currenthealth <maxHealth)
        {
            currenthealth += health;
            
           
        }

      
    }




    private void die()
    {
        Debug.Log("player has died");

        gameObject.transform.position = _cMan.lastCheckpoint;


        currenthealth = maxHealth;

        //gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 255);

       // Destroy(gameObject);
      //  SceneManager.LoadScene(2);
    }


    public void getcurrentFill()
    {
        float fillAmount = (float)currenthealth / (float)maxHealth;
        bar.fillAmount = fillAmount;
    }
}
