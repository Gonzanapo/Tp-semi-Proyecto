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
    public Vector3 Posicion;
    public Vector3 ballPositionNow;
    public float ballPositionz;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
     

        //
        ballPositionz = Random.Range(1.8f, -1.8f);
        ballPositiony = Random.Range(1.6f, 0.15f);
        dir = new Vector3(4, ballPositiony, ballPositionz) - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Posicion es la posicion donde va la pelota luego del random.range. Es la posicion Final. 
        //ballPosition es el Vector3 que tiene la posicion donde incicia y donde termina (No esta bien hecho hasta ahora)
        transform.position += dir * Time.deltaTime * ballSpeed;
       
    }
}
