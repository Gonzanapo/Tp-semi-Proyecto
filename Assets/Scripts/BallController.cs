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
    
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
     

        //
        ballPositionz = Random.Range(1.8f, -1.8f);
        ballPositiony = Random.Range(1.6f, 0.15f);
        ballPosition = new Vector3(4, ballPositiony, ballPositionz) - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Posicion es la posicion donde va la pelota luego del random.range. Es la posicion Final. 
        //ballPosition es el Vector3 que tiene la posicion donde incicia y donde termina (No esta bien hecho hasta ahora)
        transform.position += ballPosition * Time.deltaTime * ballSpeed;
       
    }
    private void OnTriggerEnter(Collider col)
    {
        Destroy(gameObject);
    }

    

}
