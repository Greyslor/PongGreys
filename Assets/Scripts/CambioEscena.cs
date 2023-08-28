using UnityEngine;
using System.Collections;

public class CambioEscena : MonoBehaviour
{

	//Script para mandar llamar otra escena


	public void ChangeToScene(string sceneToChangeTo)
	{   //M�todo p�blico para cambiar escena

		Application.LoadLevel(sceneToChangeTo); //Aqui colocamos el nombre de la escena
												//que llamaremos, se pone desde el "Inspector"
	}
}
