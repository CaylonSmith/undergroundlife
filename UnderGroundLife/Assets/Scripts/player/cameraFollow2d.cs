using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow2d : MonoBehaviour
{

    [SerializeField] GameObject player;

    [SerializeField] float timeOffset;


    [SerializeField] Vector2 posOfset;

    private Vector3 velocity;


    [SerializeField] float leftLimit;
    [SerializeField] float rightLimit;
    [SerializeField] float toplimit;
    [SerializeField] float bottomLimit;




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


       transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);

        //transform.position = Vector3.SmoothDamp(startPos, endPos, ref velocity, timeOffset);


       transform.position = new Vector3
            (


          Mathf.Clamp(transform.position.x,leftLimit,rightLimit),

          Mathf.Clamp(transform.position.y,bottomLimit,toplimit),
          transform.position.z

         );
    }




    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(new Vector2(leftLimit, toplimit), new Vector2(rightLimit, toplimit));
        Gizmos.DrawLine(new Vector2(rightLimit, toplimit), new Vector2(rightLimit, bottomLimit));
        Gizmos.DrawLine(new Vector2(rightLimit, bottomLimit), new Vector2(leftLimit, bottomLimit));
        Gizmos.DrawLine(new Vector2(leftLimit, bottomLimit), new Vector2(leftLimit, toplimit));

    }
}
