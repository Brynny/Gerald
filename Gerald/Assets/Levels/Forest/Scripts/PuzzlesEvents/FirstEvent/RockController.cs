using UnityEngine;
using System.Collections;

public class RockController : MonoBehaviour 
{
	public float rockHP = 10f;
	bool _canTrigger = false;
	static bool _pickedUpBomb = false;

	public GameObject bomb;
	public Transform player;

	public static RockController RC;

	void Awake()
	{
		RC = this;
	}

	void FixedUpdate()
	{
		//Destroy the rock if the player is next to it and presses the action button
		if (_canTrigger == true && _pickedUpBomb == true && Input.GetKeyDown (KeyCode.E)) 
		{
			Instantiate (bomb, player.position, player.rotation);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log ("Player Is Here");
			_canTrigger = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log ("Player Left");
			_canTrigger = false;
		}
	}

	public static void BombPickup()
	{
		_pickedUpBomb = true;
	}
}

