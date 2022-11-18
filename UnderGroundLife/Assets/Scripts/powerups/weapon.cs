using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
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


    public TextMeshProUGUI AmmoGunText;
  


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



       AmmoGunText.text = shotsLeft.ToString();



        if (timebtwShots <= 0)
        {
            if (allowedShoot == true)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    Instantiate(_projectile, shotPoint.position, shotPoint.rotation);

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
