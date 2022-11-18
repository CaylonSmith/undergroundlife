using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossdeath : MonoBehaviour
{
 public   GameObject spawnUprgrade;
 public   GameObject spawnTUT;
    public Transform SpawnPoint;

    // Update is called once per frame
    void Update()
    {
        spawnUpgrade();
    }


    void spawnUpgrade()
    {
        if (gameObject.GetComponent<enemyHealth>().currenthealth <= 0)
        {
            Instantiate(spawnUprgrade, SpawnPoint.position, Quaternion.identity);
            spawnTUT.SetActive(true);

            Destroy(gameObject.GetComponent<bossdeath>());
        }
    }
   
}
