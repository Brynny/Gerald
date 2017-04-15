using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageVariables : MonoBehaviour 
{
	static PlayerDamageVariables PDV;

	//Weapons 
	public static float _ARDamage = 2f;
	public static float _PlasmaGunDamage = 4f;

	// Use this for initialization
	void Awake () 
	{
		DontDestroyOnLoad (this);
	}

	void Start()
	{
		PDV = this;
	}

}
