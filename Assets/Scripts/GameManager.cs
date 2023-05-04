using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject bola;             //Definimos variable para acezar a la abola
    public GameObject player1;          //Definimos variable para acezar a player1
    public GameObject player1Goal;      //Definimos variable para acezar a portería1
    public GameObject player2;          //Definimos variable para acezar a player2
    public GameObject player2Goal;      //Definimos variable para acezar a portería2

    public Text texto1;                 //Definimos variable para acezar a texto1
    public Text texto2;                 //Definimos variable para acezar a texto2

    private int player1Score;           //Definimos referencia de puntuación jugador1
    private int player2Score;           //Definimos referencia de puntuación jugador2

    public void Player1Scored()          //Método para cambiar el marcador player1
    {
        player1Score++;                             //Incrementamos el marcador al invocar al this. método
        texto1.text = player1Score.ToString();      //Acezamos a "texto" y agregamos el valor "playerScore" convertido a "string"
        ResetPosition();
    }

    public void Player2Scored()          //Método para cambiar el marcador player2
    {
        player2Score++;                             //Incrementamos el marcador al invocar al this. método
        texto2.text = player2Score.ToString();      //Acezamos a "texto" y agregamos el valor "playerScore" convertido a "string"
        ResetPosition();                            //Reestablecemos la posición de la pelota y las paletas
    }

    private void ResetPosition()                    //Método para reestablecer las posición de la pelota y las paletas.
    {
        bola.GetComponent<Bola>().Reset();          //El método "Reset" se encuentra en el script "Bola" que mandamos llamar
        player1.GetComponent<Player>().Reset();     //El método "Reset" se encuentra en el script "Player" que mandamos llamar
        player2.GetComponent<Player>().Reset();     //El método "Reset" se encuentra en el script "Player" que mandamos llamar
                                                    //NOTA: el método "Reset" de "Bola" y "Player" no es el mismo, tienen nombres iguales.
    }

}
