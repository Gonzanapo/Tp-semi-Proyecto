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
    public float ballPosition;
    public float ballPositionz;

    // Start is called before the first frame update
    void Start()
    {
        ballPositionz = Random.Range(11, -9);
        ballPositiony = Random.Range(5,0);

        //ballPositionz = Random.Range(-4.5f, 4.5f);

      transform.position = new Vector3(13, ballPositiony, ballPositionz);


    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate()

        
        
    }
}
