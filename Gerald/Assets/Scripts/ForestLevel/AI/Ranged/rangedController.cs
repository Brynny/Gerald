using UnityEngine;
using System.Collections;

public class rangedController : MonoBehaviour
{
	public Rigidbody venomPrefab;
	Rigidbody venomInstance;
	public Transform weapon;

	public GameObject agroRange;

	float timer = 0.25f;



	public void Shoot()
	{
		timer = timer - Time.deltaTime;

		if (timer <= 0f)
		{
			venomInstance = Instantiate (venomPrefab, weapon.position, weapon.rotation) as Rigidbody;
			timer = 1f;
		}
	}
}
