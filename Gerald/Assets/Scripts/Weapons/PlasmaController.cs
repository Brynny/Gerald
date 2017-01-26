using UnityEngine;
using System.Collections;

public class PlasmaController : MonoBehaviour 
{
	public float moveSpeed;
	public Rigidbody plasma;
	float timer = 1f;


	void Start () 
	{
		plasma = GetComponent<Rigidbody>();
	}


	void Update ()
	{

	}

	void FixedUpdate()
	{
		PlasmaMovement();
		//Self destruct bullet if not destroyed within 3 seconds
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			Destroy (this.gameObject);
		}
	}

	void PlasmaMovement()
	{
		//Give bullet movement to move in a forward direction.
		plasma.velocity = transform.forward * moveSpeed;
	}
}
