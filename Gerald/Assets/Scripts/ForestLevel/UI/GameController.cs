using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController GM;

	public Text enemyCounterText;
	static float enemiesKilled = 0f;

    public Text playerLevelText;
    public static float _currentExp = 0f;
    static float _maxExp = 100f;
    static float _currentLevel = 1f;

    void Awake()
    {
        GM = this;
        DontDestroyOnLoad(this);
    }
		

	void FixedUpdate ()
	{
		UIDisplay();
        PlayerExpTracker();
	}

	void UIDisplay()
	{
		enemyCounterText.text = "Enemy Counter: " + enemiesKilled;
        playerLevelText.text = "" + _currentLevel;
	}

	static public void EnemyCount()
	{
		enemiesKilled += 1f;
	}

    static public void PlayerExpTracker()
    {
        if (_currentExp >= _maxExp)
        {
            _currentLevel = _currentLevel + 1f;
            _currentExp = 0f;
            _maxExp = _maxExp * 1.2f;
        }

    }

    static public void WolfExp()
    {
        _currentExp = _currentExp + 25f;
    }

    static public void SnakeExp()
    {
        _currentExp = _currentExp + 35f;
    }

}
