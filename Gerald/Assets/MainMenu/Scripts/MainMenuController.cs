using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{
	//Main Menu
	public void NewGame()
	{
		SceneManager.LoadScene ("PlayerHub");
	}

	public void QuitGame () 
	{
		Application.Quit ();
	}

	//In Game Menu
	public void MainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
