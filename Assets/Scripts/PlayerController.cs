﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera C;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = C.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos + new Vector3(-2, 0, 0);
    }
}


/*
 COSAS Q HAY Q ARREGLAR
 - Movilidad del arquero, solo me anda cuando la camara esta en ortografica, no en perspectiva
 - Colision de la pelota con las cosas (Hecho)
 - Tener un tiempo para penasr, una espera de al menos 5 seg al entrar al juego, porque sino es dificil
 - Darle a la pelota un movimiento un poco mas realista, en vez de ir completamente recto (opcional)

     */