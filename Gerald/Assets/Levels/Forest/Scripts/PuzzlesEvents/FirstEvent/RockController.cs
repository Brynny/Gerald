using UnityEngine;
using System.Collections;

public class RockController : MonoBehaviour 
{
	public float rockHP = 10f;

//	void FixedUpdate()
//	{
//		if (rockHP <= 0)
//		{
//			Destroy (this.gameObject);
//		}
//	}
//
//	void OnTriggerEnter(Collider other)
//	{
//		if (other.gameObject.tag == "Bullet")
//		{
//			rockHP -= 1f;
//		}
//	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && Input.GetKeyDown (KeyCode.E))
		{
			Debug.Log ("Player Is Here");
			Destroy (this.gameObject);
		}
	}

}

