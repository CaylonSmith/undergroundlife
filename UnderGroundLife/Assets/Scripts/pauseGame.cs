using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{

    public bool gamePaused = false;
    public GameObject pauseMenu;

    manager_checkPoint _cMan;
    playerHealth _playerhealth;
    

    private void Start()
    {
        _cMan = GameObject.FindGameObjectWithTag("cMan").GetComponent<manager_checkPoint>();
        _playerhealth = GameObject.FindGameObjectWithTag("Player").GetComponent<playerHealth>();

       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            if (gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
               pauseMenu.SetActive(true);
               
              

            }
            else
            {
               pauseMenu.SetActive(false);
                gamePaused = false;
                Time.timeScale = 1;
               // pauseMenu.transform.position = new Vector2(-56.4391f, 1110);

            }
        }
    }


 public   void pauseTheGame()
    {
        Time.timeScale = 0;
        gamePaused = true;
        pauseMenu.SetActive(true);
       
    }


  public  void unpauseTheGame()
    {
        pauseMenu.SetActive(false);
        gamePaused = false;
        Time.timeScale = 1;
       
    }





    public void loadCheckPoint()
    {
        gameObject.transform.position = _cMan.lastCheckpoint;


        _playerhealth.takeDamage(1000);
    }





}
