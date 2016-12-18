using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour 
{
	public float moveSpeed;
	public Rigidbody bullet;
	float timer = 1f;


	void Start () 
	{
		bullet = GetComponent<Rigidbody>();
	}
	

	void Update ()
	{
	
	}

	void FixedUpdate()
	{
		BulletMovement();
		//Self destruct bullet if not destroyed within 3 seconds
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			Destroy (this.gameObject);
		}
	}

	void BulletMovement()
	{
		//Give bullet movement to move in a forward direction.
		bullet.velocity = transform.forward * moveSpeed;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject) 
		{
			Debug.Log("Collider with "+other.gameObject.name);
			Destroy (this.gameObject);

		}
	}
}
