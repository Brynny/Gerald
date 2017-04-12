using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AmmoController : MonoBehaviour
{
	public static AmmoController AC;

	public static float _ARMaxAmmo = 200f;
	public static float _ARCurrentAmmo;
	public Text AmmoText;

	public float PGMaxAmmo;
	public float PGCurrentAmmo;

	//public GameObject WeaponSwapControllerGO;

	void Awake()
	{
		AC = this;
	}

	void Start ()
	{
		_ARCurrentAmmo = _ARMaxAmmo;
	}

	void FixedUpdate()
	{
		//Display Ammo Text On UI
		AmmoText.text = "Assault Rifle Ammo: " + _ARCurrentAmmo + " / " + _ARMaxAmmo;
	}

	public static void ARAmmoDecrease()
	{
		_ARCurrentAmmo = _ARCurrentAmmo - 1f;
	}

	public void BulletPackPickup()
	{
		_ARCurrentAmmo += 20f;
	}

	public static void ARAmmoController()
	{
		//If Ammo is more than 200, limit it to 200.
		if (_ARCurrentAmmo >= 200f)
			_ARCurrentAmmo = 200f;

		if (_ARCurrentAmmo <= 0f)
			_ARCurrentAmmo = 0;
	}

	public void PGAmmoController()
	{
		AmmoText.text = PGCurrentAmmo + "/" + PGMaxAmmo;
	}
}
