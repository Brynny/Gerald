using UnityEngine;
using System.Collections;

public class PlasmaGunController : MonoBehaviour
{
	public Rigidbody plasmaPrefab;
	public Transform PlasmaGun;

	float timer = 1f;


	void FixedUpdate ()
	{
		Shoot();
	}

	void Shoot ()
	{
		timer = timer - Time.deltaTime;

		if (Input.GetMouseButton (0) && timer <= 0)
		{
			Instantiate (plasmaPrefab, PlasmaGun.position, PlasmaGun.rotation);
			timer = 2f;
		}
	}
}
