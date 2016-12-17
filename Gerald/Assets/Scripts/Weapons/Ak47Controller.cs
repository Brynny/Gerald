using UnityEngine;
using System.Collections;

public class Ak47Controller : MonoBehaviour 
{

	public Rigidbody bulletPrefab;
	Rigidbody bulletInstance;
	public Transform AssaultRifleGun;
	float timer = 0.25f;


	void Start () 
	{
	
	}

	void Update () 
	{
		Shoot();
	}

	void Shoot ()
	{
		timer = timer - Time.deltaTime;

		if (Input.GetMouseButton (0) && timer <= 0)
			{
				bulletInstance = Instantiate (bulletPrefab, AssaultRifleGun.position, AssaultRifleGun.rotation) as Rigidbody;
			timer = 0.25f;
			}
	}
}
