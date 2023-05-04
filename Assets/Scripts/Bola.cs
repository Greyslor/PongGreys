using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float speed = 7 ;        //definimos la velocidad de la pelota
    public Rigidbody2D rb;          //Declaramos [instanciamos] un "rb" de la pelota para poder acezarla
    private Vector2 starPos;        //posición inicial de la pelota

    void Start()
    {
        transform.position = starPos;       //guardamos en "startpos" las coordenadas iniciales de la palota
        Trayectoria();                      //mandamos llamar al método "Trayectoria"
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;             //ponemos los valores de "rb" a cero ( reset)
        transform.position = starPos;           //ahora invertimos la línea 15,
                                                //aquí recuperamos la posición original de las paletas.
        Trayectoria();                          //mandamos llamar el método "Trayectoria"
                                                //para reiniciar el lanzamiento de la bola
    }

    public void Trayectoria()                   //En forma aleatoria la pelota puede salir hacia aribba, abajo, izquierda o derecha.
    {
        float x = Random.Range (0,2) == 0 ? -1 : 1 ;    //Asignamos a "x" un valor -1 o 1 de acuerdo al Random (0,2)
                                                        //si el Random = 0 entonces  x= -1 de otro modo x = 1
        float y = Random.Range (0,2) == 0 ? -1 : 1;    //Asignamos a "y" un valor -1 o 1 de acuerdo al Random (0,2)
                                                       //si el Random = 0 entonces  y = -1 de otro modo y = 1

        Debug.Log("X= " + x);
        Debug.Log("Y= " + y);

        rb.velocity = new Vector2(speed * x, speed * y);    //agregamos velocidad a los valores de "x" y "y".
    }
}
