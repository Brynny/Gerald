using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCube : MonoBehaviour 
{
	public static BlueCube BC;

	public static float _pickedUpNum = 0f;

	void Awake()
	{
		BC = this;
	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
			_pickedUpNum = 1f;
			Destroy (this.gameObject);
	}
}
