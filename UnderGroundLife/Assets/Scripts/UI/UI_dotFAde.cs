using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class UI_dotFAde : MonoBehaviour
{


    SpriteRenderer sp;

   public Material bg;

    void Start()
    {

        bg = gameObject.GetComponent<Material>();

        bg.DOFade(0.5f, 0.5f);



    }

}
