using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WeaponSwapController : MonoBehaviour
{
	public GameObject AssaultRifle;
	public GameObject PlasmaGun;
	public Text currentWeapon;

	public bool PlasmaGunEquipped = false;


	void Start () 
	{
		AssaultRifle.SetActive(true);
		PlasmaGun.SetActive(false);
		currentWeapon.text = "Assault Rifle";
	}
	

	void Update () 
	{
		WeaponSwitch();
	}

	public void PlasmaGunPickedUp()
	{
		PlasmaGunEquipped = true;
	}

	public void WeaponSwitch()
	{
		if (Input.GetKeyDown("1"))
		{
			AssaultRifle.SetActive(true);
			PlasmaGun.SetActive(false);
			currentWeapon.text = "Assault Rifle";
		}

		if (Input.GetKeyDown("2") && PlasmaGunEquipped == true)
		{
			AssaultRifle.SetActive(false);
			PlasmaGun.SetActive(true);
			currentWeapon.text = "Plasma Gun";
		}

	}
}
