using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    
    float camara;
  

    Vector3 ballPosition;

    public GameObject ballPoint;
    public GameObject ball;

    float customTime;
    float timeToDoSomething;
    float timeToWait;

    public float ballSpeed;
    float ballPositionz;
    float ballPositiony;
    Rigidbody rbBall;
    Transform position;
    Transform rotation;
    GameObject clon;
    // Start is called before the first frame update
    void Start()
    {
        customTime = 0;
        timeToDoSomething = timeToWait;



    }

    // Update is called once per frame
    void Update()
    {
        //Posicion es la posicion donde va la pelota luego del random.range. Es la posicion Final. 
        //ballPosition es el Vector3 que tiene la posicion donde incicia y donde termina (No esta bien hecho hasta ahora)

        //Destroy(ballPoint, 3);

    
    

        customTime.ToString();

        /*if (Time.time > timeToDoSomething)
        {
           
            //ball.transform.position = new Vector3(4, ballPositiony, ballPositionz) - transform.position;
            ballPosition = new Vector3(4, ballPositiony, ballPositionz) - transform.position;
            ballPoint.transform.position = new Vector3(3, ballPositiony, ballPositionz);
            timeToDoSomething += timeToWait;
        }
        //transform.position += ball.transform.position * Time.deltaTime * ballSpeed;
        transform.position += ballPosition * Time.deltaTime * ballSpeed;
        */


        //if(Time.time > 5)
        if(Input.GetMouseButtonDown(0))
        {
            ballPositionz = Random.Range(1.3f, -1.2f);
            ballPositiony = Random.Range(1.2f, 0.12f);
            Vector3 tempV3 = new Vector3(3.429749f, ballPositiony, ballPositionz);
            Vector3 direction = tempV3 - transform.position;
            clon = Instantiate(ball, transform.position, transform.rotation);
            rbBall = clon.GetComponent<Rigidbody>();
            if(rbBall)
            rbBall.AddForce(direction* ballSpeed, ForceMode.Impulse);
            //Destroy(clon, 1);
        }
    }
    
    private void OnTriggerEnter(Collider col)
    {
        Destroy(clon);
    }




}


    
