using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInformationController : MonoBehaviour 
{
	public Text maxARAmmoText;
	public Text playerMoveSpeedText;
	public Text playerLevelText;

	void Awake()
	{
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Information ();
	}

	void Information()
	{
		maxARAmmoText.text = "" + AmmoController._ARMaxAmmo;
		playerMoveSpeedText.text = "" + GameController._playerMoveSpeed;
		playerLevelText.text = "" + GameController._currentLevel;
	}


}
