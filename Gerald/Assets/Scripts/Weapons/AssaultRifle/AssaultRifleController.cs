using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AssaultRifleController : MonoBehaviour 
{
	//public GameObject AmmoController;

	public GameObject explosion;

	public Rigidbody bulletPrefab;
	Rigidbody bulletInstance;
	public Transform AssaultRifleGun;
	float timer = 0.25f;

	void FixedUpdate () 
	{
		Shoot();
		AmmoController.ARAmmoController ();
		//AmmoController.GetComponent<AmmoController>().ARAmmoController();
	}

	void Shoot ()
	{
		timer = timer - Time.deltaTime;

		if (Input.GetMouseButton (0) && timer <= 0 && AmmoController._ARCurrentAmmo > 0)
		{
			Debug.Log ("Shooting");
			Instantiate (explosion, AssaultRifleGun.position, AssaultRifleGun.rotation);
			Instantiate (bulletPrefab, AssaultRifleGun.position, AssaultRifleGun.rotation);
			AmmoController.ARAmmoDecrease ();
			timer = 0.25f;
		}
	}
}

//&& AmmoController.GetComponent<AmmoController>().ARCurrentAmmo > 0