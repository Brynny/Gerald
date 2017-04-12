using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHubController : MonoBehaviour
{
	public void CastleLevel()
	{

	}

	public void ForestLevel()
	{
		SceneManager.LoadScene ("Forest");
	}

	public void MainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
