using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombPlacement : MonoBehaviour
{
	public float timer = 3f;

	void FixedUpdate () 
	{
		BombTimer ();
		BombSelfDestruct ();
	}

	void BombSelfDestruct()
	{
		if (timer <= 0f) 
		{
			RockController.CanSelfDestruct ();
			Destroy (this.gameObject);
		}
	}

	void BombTimer()
	{
		Debug.Log (timer);
		timer -= Time.deltaTime;
		if (timer <= 0f)
			timer = 0f;
	}
}
