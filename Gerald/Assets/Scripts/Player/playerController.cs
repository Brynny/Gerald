﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour 
{

	public float currentPlayerHealth = 0f;
	public float maxPlayerHealth = 100f;

	float calcHealth;

	float healthPercentage;

	public Image healthBar;

	void Start () 
	{
		currentPlayerHealth = maxPlayerHealth;
	}


	void FixedUpdate () 
	{		
		PlayerHP();
	}

	void OnTriggerEnter(Collider other)
	{
		//If The Player Is Attacked By The Wolf, DO Damage
		if(other.gameObject.tag == "Wolf")
		{
			currentPlayerHealth = currentPlayerHealth - 10f;
		}
	}

	void PlayerHP ()
	{
		calcHealth = currentPlayerHealth / maxPlayerHealth;
		SetHealthBar(calcHealth);
	}

	//Display Health on bar

	public void SetHealthBar (float myHealth)
	{
		healthBar.fillAmount = myHealth;
	}

}
