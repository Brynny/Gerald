using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AssaultRifleController : MonoBehaviour 
{
	public GameObject AmmoController;

	public GameObject explosion;

	public Rigidbody bulletPrefab;
	Rigidbody bulletInstance;
	public Transform AssaultRifleGun;
	float timer = 0.25f;

	void FixedUpdate () 
	{
		Shoot();
		AmmoController.GetComponent<AmmoController>().ARAmmoController();
	}

	void Shoot ()
	{
		timer = timer - Time.deltaTime;

		if (Input.GetMouseButton (0) && timer <= 0 && AmmoController.GetComponent<AmmoController>().ARCurrentAmmo > 0)
		{
			Instantiate (explosion, AssaultRifleGun.position, AssaultRifleGun.rotation);
			bulletInstance = Instantiate (bulletPrefab, AssaultRifleGun.position, AssaultRifleGun.rotation) as Rigidbody;
			AmmoController.GetComponent<AmmoController>().ARAmmoDecrease();
			timer = 0.25f;
		}
	}
}
