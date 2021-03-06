﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController GM;

	public Text enemyCounterText;
	static float enemiesKilled = 0f;

	//Player Experience
    public Text playerLevelText;
    public static float _currentExp = 0f;
    static float _maxExp = 100f;
	public static float _currentLevel = 1f;

	//Player Variables
	public static float _playerMoveSpeed = 10f;
//	public static float _playerCurHealth;
//	public static float _playerMaxHealth = 100f;

	//In Game Menu 
	public GameObject InGameMenu;
	bool isPaused = false;

	//PlayerPrefs
	int levelToLoad;

    void Awake()
    {
        GM = this;
        DontDestroyOnLoad(this);
		Time.timeScale = 1.0f;
    }
		
	void Update()
	{
		TriggerInGameMenu ();
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

	void TriggerInGameMenu()
	{
		if (Input.GetKeyDown (KeyCode.Escape) && isPaused == false) 
		{
			InGameMenu.SetActive(true);
			Time.timeScale = 0.0f;
			isPaused = true;
		}

		else if (Input.GetKeyDown (KeyCode.Escape) && isPaused == true) 
		{
			InGameMenu.SetActive(false);
			Time.timeScale = 1.0f;
			isPaused = false;
		}
	}

	void SaveLevel()
	{
		
	}

	public void LoadLevel()
	{
		
	}
}
