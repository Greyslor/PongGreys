using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool Player1Goal;         //Determinamos con esta variable si metimos gol a portería 1 o 2 haciendola falsa o verdadera
    public GameObject gameManager;  //Declaramos una variable de Instancia por Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))                       //Si la colosión es del GameObject "Bola"
        {
            if (Player1Goal)
            {
                gameManager.GetComponent<GameManager>().Player1Scored();        //Abre el script "GameManager" y ejecuta método "Player1Scored"
            }
            else                                                    //De otro modo......
            {
                gameManager.GetComponent<GameManager>().Player2Scored();        //Abre el script "GameManager" y ejecuta método "Player2Scored"
            }
        }

    }
}
