using UnityEngine;
using System.Collections;

public class WolfController : MonoBehaviour 
{
	public float wolfHealth = 10f;

	void Start () 
	{
	
	}

	void FixedUpdate () 
	{
		WolfDeath();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Bullet")
		{
			Destroy (other.gameObject);
			wolfHealth = wolfHealth - 2f;
		}
	}

	void WolfDeath()
	{
		if (wolfHealth <= 0)
		{
			Destroy (this.gameObject);
		}
	}
}
