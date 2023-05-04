using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool player1;             //Usamos true o false para saver en que GameObject esta el script "playr1" o "player2".
    public float speed = 3;         //velocidad de las paletas de los jugadores
    public Rigidbody2D rb;          //RigidBody de las paletas de los jugadores para poder acezarlas

    private float move;             //Velocidad de movimiento de las paletas de los jugadores.
    private Vector2 startPos;       //Posición de inicio de las paletas de los jugadores, para reataurar despues de anotar
    void Start()
    {
        startPos = transform.position;  //Aquí guardamos en "starPos" las coordenadas de las paletas al iniciaar el juego
    }

    // Detectamos en que player esta el script
    void Update()
    {
        if (player1)
        {
            move = Input.GetAxisRaw("Vertical");    //si es el player1 usa flecha arriba y abajo
        }
        else
        {
            move = Input.GetAxisRaw("Vertical2");   //si es el player2 usa flecha "W" y "S"
        }
        rb.velocity = new Vector2(rb.velocity.x, move * speed); //cualquiera que sea el "Player" aplicale a su  "rb" una velocidad

    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;             //ponemos los valores de "rb" a cero ( reset)
        transform.position = startPos;          //ahora invertimos la línea 15, aquí recuperamos la posición original de las paletas.
    }
}
