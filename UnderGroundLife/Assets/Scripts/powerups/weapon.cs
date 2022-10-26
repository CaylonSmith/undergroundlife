using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

    public GameObject _projectile;

    public Transform shotPoint;
    public float timebtwShots;
    public float startTimebtwShots;
    public float speed;
    public int maxShots;
    public int shotsLeft;
    public bool allowedShoot;





    private void Start()
    {
        shotsLeft = maxShots;
        allowedShoot = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (shotsLeft <= 0)
        {
            allowedShoot = false;
        }

       
      
        


        if (timebtwShots <= 0)
        {
            if (allowedShoot == true)
            {
                if (Input.GetKeyDown(KeyCode.L))
                {
                    Instantiate(_projectile, shotPoint.position, transform.rotation);

                    shotsLeft -= 1;

                    timebtwShots = startTimebtwShots;
                }
            }
        }
        else
        {
            timebtwShots -= Time.deltaTime;
        }
    }


   
}
