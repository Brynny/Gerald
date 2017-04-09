using UnityEngine;
using System.Collections;

public class RockController : MonoBehaviour 
{
	public GameObject _PlayerCamera;

	public float rockHP = 10f;
	bool _canTrigger = false;

	static bool _pickedUpBomb = false;
	public GameObject bomb;
	public Transform player;
	int _bombAmount = 1;

	//Self Destruct Bool
	static bool _canSelfDestruct = false;

	public static RockController RC;

	void Awake()
	{
		RC = this;
	}

	void FixedUpdate()
	{
		//Destroy the rock if the player is next to it and presses the action button
		if (_canTrigger == true && _pickedUpBomb == true && Input.GetKeyDown (KeyCode.E) && _bombAmount == 1) 
		{
			Instantiate (bomb, player.position, player.rotation);
			_bombAmount = 0;
		}

		SelfDestruct ();
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

	public void SelfDestruct()
	{
		if (_canSelfDestruct == true) 
		{
			_PlayerCamera.GetComponent<ScreenShake>().DoShake ();
			Destroy (this.gameObject);
		}
	}

	public static void BombPickup()
	{
		_pickedUpBomb = true;
	}

	public static void CanSelfDestruct()
	{
		_canSelfDestruct = true;
	}
}

