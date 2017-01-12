using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	public Text enemiesRemainingText;
	public float enemiesRemaining = 19f;
		

	void FixedUpdate ()
	{
		UIDisplay();
	}

	void UIDisplay()
	{
		enemiesRemainingText.text = "Enemies Remaining: " + enemiesRemaining;
	}

	public void EnemyCount()
	{
		enemiesRemaining -= 1f;
	}
}
