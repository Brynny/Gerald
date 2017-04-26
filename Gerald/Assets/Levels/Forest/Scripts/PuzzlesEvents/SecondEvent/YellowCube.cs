using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCube : MonoBehaviour
{
	public static YellowCube YC;

	public static float _pickedUpNum = 0f;

	void Awake()
	{
		YC = this;
	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
			_pickedUpNum = 1f;
		Destroy (this.gameObject);
	}
}