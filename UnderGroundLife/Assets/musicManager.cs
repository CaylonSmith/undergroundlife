using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicManager : MonoBehaviour
{

  public GameObject music1;
  public GameObject music2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            destroyPickup();
        }
    }

    void destroyPickup()
    {
        music1.SetActive(false);

        music2.SetActive(true);
}


}
