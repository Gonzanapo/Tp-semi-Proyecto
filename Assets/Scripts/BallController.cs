using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    public float ballSpeed;
    public float camara;
    float ballPositionz;
    float ballPositiony;
    Vector3 ballPosition;
    public GameObject ballPoint;
    public GameObject ball;
    public float customTime;
    public bool isCounting;
    public float timeToDoSomething;
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
            ballPositionz = Random.Range(1.8f, -1.8f);
            ballPositiony = Random.Range(1.6f, 0.15f);
            ballPosition = new Vector3(4, ballPositiony, ballPositionz) - transform.position;
            ballPoint.transform.position = new Vector3(3, ballPositiony, ballPositionz);
            timeToDoSomething += timeToWait;
        }
        transform.position += ballPosition * Time.deltaTime * ballSpeed;





    }
    private void OnTriggerEnter(Collider col)
    {
        Destroy(ball);
    }

    

}
