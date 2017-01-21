using UnityEngine;
using System.Collections;

public class WeaponSwapController : MonoBehaviour
{
	public GameObject AssaultRifle;
	public GameObject GunTwo;

	void Start () 
	{
		AssaultRifle.SetActive(true);
		GunTwo.SetActive(false);
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
		}

		if (Input.GetKeyDown("2"))
		{
			AssaultRifle.SetActive(false);
			GunTwo.SetActive(true);
		}

	}
}
