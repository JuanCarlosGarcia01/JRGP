using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio : MonoBehaviour
{

   


	void Update()
	{
		if (Input.GetKeyDown("r"))
		{
			SceneManager.LoadScene("Juego");
		}

	}
}
