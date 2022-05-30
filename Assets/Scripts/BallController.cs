using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    public float ballSpeed;
    public float camara;
  
    public float ballPositionx;
    public float ballPositiony;
    public Vector3 ballPosition;
    public Vector3 ballPositionNow;
    public float ballPositionz;

    // Start is called before the first frame update
    void Start()
    {
        ballPositionz = Random.Range(1.8f, -1.8f);
        ballPositiony = Random.Range(1.6f,0.15f);

        //ballPositionz = Random.Range(-4.5f, 4.5f);

      


    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate()
        ballPosition = (transform.position = new Vector3(3.5f, ballPositiony, ballPositionz));

        for (Vector3 i = ballPositionNow; i != ballPosition;  )
        {

        }


    }
}
