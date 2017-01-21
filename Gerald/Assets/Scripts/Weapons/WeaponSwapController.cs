using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WeaponSwapController : MonoBehaviour
{
	public GameObject AssaultRifle;
	public GameObject GunTwo;
	public Text currentWeapon;


	void Start () 
	{
		AssaultRifle.SetActive(true);
		GunTwo.SetActive(false);
		currentWeapon.text = "Assault Rifle";
	}
	

	void FixedUpdate () 
	{
		WeaponSwitch();
	}

	void WeaponSwitch()
	{
		if (Input.GetKeyDown("1"))
		{
			AssaultRifle.SetActive(true);
			GunTwo.SetActive(false);
			currentWeapon.text = "Assault Rifle";
		}

		if (Input.GetKeyDown("2"))
		{
			AssaultRifle.SetActive(false);
			GunTwo.SetActive(true);
			currentWeapon.text = "Plasma Gun";
		}

	}
}
