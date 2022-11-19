using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathBox : MonoBehaviour
{
    manager_checkPoint _cMan;
    playerHealth _playerhealth;

    private void Start()
    {
        _cMan = GameObject.FindGameObjectWithTag("cMan").GetComponent<manager_checkPoint>();
        _playerhealth = GameObject.FindGameObjectWithTag("Player").GetComponent<playerHealth>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.transform.position = _cMan.lastCheckpoint;


            _playerhealth.currenthealth += 75;
        }
    }
   
}
