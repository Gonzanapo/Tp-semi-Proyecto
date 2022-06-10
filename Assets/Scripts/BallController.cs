using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    public float ballSpeed;
    float camara;
    float ballPositionz;
    float ballPositiony;
    Vector3 ballPosition;
    public GameObject ballPoint;
    public GameObject ball;
    float customTime;
    float timeToDoSomething;
    public float timeToWait;

                
    // Start is called before the first frame update
    void Start()
    {
        customTime = 0;
        timeToDoSomething = timeToWait;

        //
        //for (int i = 0; i <= 5; i++)
       // {
         
        //    Debug.Log("Goalkeepers Game");
       // }
    }

    // Update is called once per frame
    void Update()
    {
        //Posicion es la posicion donde va la pelota luego del random.range. Es la posicion Final. 
        //ballPosition es el Vector3 que tiene la posicion donde incicia y donde termina (No esta bien hecho hasta ahora)

        //Destroy(ballPoint, 3);

    
    

        customTime.ToString();

        if (Time.time > timeToDoSomething)
        {
            ballPositionz = Random.Range(1.3f, -1.2f);
            ballPositiony = Random.Range(1.2f, 0.12f);
            //ball.transform.position = new Vector3(4, ballPositiony, ballPositionz) - transform.position;
            ballPosition = new Vector3(4, ballPositiony, ballPositionz) - transform.position;
            ballPoint.transform.position = new Vector3(3, ballPositiony, ballPositionz);
            timeToDoSomething += timeToWait;
        }
        //transform.position += ball.transform.position * Time.deltaTime * ballSpeed;
        transform.position += ballPosition * Time.deltaTime * ballSpeed;




    }
    private void OnTriggerEnter(Collider col)
    {
        Destroy(ball);
    }

    

}
