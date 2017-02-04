using UnityEngine;
using System.Collections;

public class RockController : MonoBehaviour 
{
	public float rockHP = 10f;

	void FixedUpdate()
	{
		if (rockHP <= 0)
		{
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bullet")
		{
			rockHP -= 1f;
		}
	}

}

