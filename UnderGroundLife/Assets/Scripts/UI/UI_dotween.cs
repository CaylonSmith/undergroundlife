using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class UI_dotween : MonoBehaviour
{


    public Vector2 Originalscale;
    public Vector2 Scale2Be;
    // Start is called before the first frame update
    void Start()
    {

        Originalscale = transform.localScale;
        Scale2Be = Originalscale * 1.5f;

        transform.DOScale(Scale2Be, 0.5f).SetEase(Ease.OutBounce);

    }


     
    // Update is called once per frame
    void Update()
    {
        
    }
}
