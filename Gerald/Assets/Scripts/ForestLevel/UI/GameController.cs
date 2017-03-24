using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController GM;

	public Text enemyCounterText;
	static float enemiesKilled = 0f;

    static float _playerExp = 0f;

    void Awake()
    {
        GM = this;
        DontDestroyOnLoad(this);
    }
		

	void FixedUpdate ()
	{
		UIDisplay();
	}

	void UIDisplay()
	{
		enemyCounterText.text = "Enemy Counter: " + enemiesKilled;
	}

	static public void EnemyCount()
	{
		enemiesKilled += 1f;
	}

    static public void wolfExp()
    {
        _playerExp = _playerExp + 25f;
    }
}
