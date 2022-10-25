using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow2d : MonoBehaviour
{

    [SerializeField] GameObject player;

    [SerializeField] float timeOffset;


    [SerializeField] Vector2 posOfset;

    private Vector3 velocity;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 startPos = transform.position;
        Vector3 endPos = player.transform.position;
        endPos.x += posOfset.x;
        endPos.y += posOfset.y;
        endPos.z = -10;


       // transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);

        transform.position = Vector3.SmoothDamp(startPos, endPos, ref velocity, timeOffset);
    }
}
