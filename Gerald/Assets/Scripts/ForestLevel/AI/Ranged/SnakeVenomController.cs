using UnityEngine;
using System.Collections;

public class SnakeVenomController : MonoBehaviour 
{
	public float moveSpeed;
	Rigidbody venom;
	float timer = 3f;


	void Start () 
	{
		venom = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		VenomMovement();

		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			Destroy (this.gameObject);
		}
	}

	void VenomMovement()
	{
		venom.velocity = transform.forward * moveSpeed;
	}
}
