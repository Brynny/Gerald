using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondEventController : MonoBehaviour
{
	void FixedUpdate()
	{
		if (BlueCube._pickedUpNum == 1f && RedCube._pickedUpNum == 1f && YellowCube._pickedUpNum == 1f) 
		{
			Destroy (this.gameObject);
		}
	}
}
