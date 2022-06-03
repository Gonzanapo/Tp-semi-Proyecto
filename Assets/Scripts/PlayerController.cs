using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode mouse;
    public GameObject arquero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos + new Vector3(-1, 0, 0);
        //if()
        //{
        //    Vector3 mousePos =  Input.mousePosition;
        //    Debug.Log(mousePos.x);
        //    Debug.Log(mousePos.y);
        //}

    }
}
