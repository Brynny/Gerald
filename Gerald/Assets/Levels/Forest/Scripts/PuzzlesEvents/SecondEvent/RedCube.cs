using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : MonoBehaviour 
{
	public static RedCube RC;

	public static float _pickedUpNum = 0f;

	void Awake()
	{
		RC = this;
	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
			_pickedUpNum = 1f;
		Destroy (this.gameObject);
	}
}