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

	public void Continue()
	{

	}

	//In Game Menu
	public void MainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
