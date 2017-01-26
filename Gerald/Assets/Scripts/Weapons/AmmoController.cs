using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AmmoController : MonoBehaviour
{
	public float ARMaxAmmo;
	public float ARCurrentAmmo;
	public Text AmmoText;

	public float PGMaxAmmo;
	public float PGCurrentAmmo;

	public GameObject WeaponSwapControllerGO;

	public void ARAmmoDecrease()
	{
		ARCurrentAmmo = ARCurrentAmmo - 1f;
	}

	public void BulletPackPickup()
	{
		ARCurrentAmmo += 20f;
	}

	public void ARAmmoController()
	{
		//Display Ammo Text On UI
		AmmoText.text = "Assault Rifle Ammo: " + ARCurrentAmmo + " / " + ARMaxAmmo;

		//If Ammo is more than 200, limit it to 200.
		if (ARCurrentAmmo >= 200f)
			ARCurrentAmmo = 200f;

		if (ARCurrentAmmo <= 0f)
			ARCurrentAmmo = 0;
	}

	public void PGAmmoController()
	{
		AmmoText.text = PGCurrentAmmo + "/" + PGMaxAmmo;
	}
}
