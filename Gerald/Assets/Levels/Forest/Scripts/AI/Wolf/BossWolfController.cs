using UnityEngine;
using System.Collections;

public class BossWolfController : MonoBehaviour 
{
	//Wolf Health
	public float wolfHealth = 30f;

	//Spawn Ammo
	public GameObject[] Loot;
	public GameObject wolfBlood;

	float dropRate = 1f;

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
			Instantiate (wolfBlood, transform.position, transform.rotation);
		}
	}

	void WolfDeath()
	{
		if (wolfHealth <= 0)
		{
			if (Random.Range(0f, 1f) <= dropRate)
			{
				Instantiate (Loot[Random.Range(0, 2)], transform.position, Quaternion.identity);
			}
			Destroy (this.gameObject);
		}
	}
}
