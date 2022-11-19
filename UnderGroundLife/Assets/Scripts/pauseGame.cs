using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{

    public bool gamePaused = false;
    public GameObject pauseMenu;




    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
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
}
