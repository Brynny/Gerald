using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	public Text enemiesRemainingText;
	public float enemiesKilled = 0f;
		

	void FixedUpdate ()
	{
		UIDisplay();
	}

	void UIDisplay()
	{
		enemiesRemainingText.text = "Enemy Counter: " + enemiesKilled;
	}

	public void EnemyCount()
	{
		enemiesKilled += 1f;
	}
}
