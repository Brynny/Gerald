using UnityEngine;
using System.Collections;

public class rangedController : MonoBehaviour
{
	public Rigidbody bulletPrefab;
	Rigidbody bulletInstance;
	public Transform weapon;

	public GameObject agroRange;

	float timer = 0.25f;

	public void Shoot()
	{
		timer = timer - Time.deltaTime;

		if (timer <= 0f)
		{
			bulletInstance = Instantiate (bulletPrefab, weapon.position, weapon.rotation) as Rigidbody;
			timer = 0.5f;
		}
	}
}
