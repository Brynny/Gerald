using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ak47Controller : MonoBehaviour 
{

	public Rigidbody bulletPrefab;
	Rigidbody bulletInstance;
	public Transform AssaultRifleGun;
	float timer = 0.25f;

	public float currentAmmo = 50f;
	public float maxAmmo = 50f;

	public Text ammoText;

	void Start () 
	{
	
	}

	void FixedUpdate () 
	{
		Shoot();
		GunAmmo();
	}

	void Shoot ()
	{
		timer = timer - Time.deltaTime;

		if (Input.GetMouseButton (0) && timer <= 0 && currentAmmo > 0f)
		{
			bulletInstance = Instantiate (bulletPrefab, AssaultRifleGun.position, AssaultRifleGun.rotation) as Rigidbody;
			currentAmmo = currentAmmo - 1f;
			timer = 0.25f;
		}
	}

	public void BulletPackPickup()
	{
		currentAmmo += 10f;
	}

	void GunAmmo()
	{
		//Display Ammo Text On UI
		ammoText.text = "Ammo: " + currentAmmo + " / " + maxAmmo;

		//If Ammo is more than 50, limit it to 50.
		if (currentAmmo >= 50f)
			currentAmmo = 50f;

		if (currentAmmo <= 0f)
			currentAmmo = 0;
	}
}
