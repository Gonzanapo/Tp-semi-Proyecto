using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    public Text txtAtajados;
    public Text txtGoles;
    float camara;
    int tiros = 0;
    int atajados = 0;
    int goles = 0;
   

    Vector3 ballPosition;

    public GameObject ballPoint;
    public GameObject ball;
    public GameObject gameOver;
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
    public GameObject arquero;
    public static GameObject _arquero;
    public static int _tiros;
    public static int _atajados;
    public static int _goles;


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

    
            //for(int i = 0; i>1; i++)
            //{
              //  Debug.Log("Bokita papa");
            //}

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

        _tiros = tiros;
        _atajados = atajados;
        _goles = goles;

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
            tiros--;
            txtAtajados.text = (" Tiros Atajados: " + atajados + " ");
            txtGoles.text = (" Goles en Contra: " + goles + " ");
        }
        if (tiros == 0)
        {

            //Time.timeScale = 0;
            //Debug.Log("Ganaste!");
            gameOver.SetActive(true);
           
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //cuando colisione en el lugar que no es trigger q se empuje para un lado como en la vida real

        //Si la pelota iba a la derecha, se empuje para alla - Si la pelota iba a la izquierda, se empuje a la izquierda.

        if (other.gameObject.name == "arquero")
        {
            atajados++;
            goles = tiros - atajados;
        }
            
    }

    //private void OnTriggerEnter(Collider col)
    //{
     //   Destroy(clon);
   // }




}


    
