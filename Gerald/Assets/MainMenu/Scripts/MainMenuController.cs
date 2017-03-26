using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{
	public void NewGame()
	{
		SceneManager.LoadScene ("Forest");
	}

	public void QuitGame () 
	{
		Application.Quit ();
	}
}
