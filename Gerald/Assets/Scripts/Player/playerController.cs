using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour 
{
	public GameObject GameController;

	public GameObject AssaultRifle;
	public GameObject weaponSlot;
	public GameObject PlasmaGunPickUpTextGO;

	public GameObject playerFlashLight;
	public bool playerFlashLightEnabled = true;

	public float currentPlayerHealth = 0f;
	public float maxPlayerHealth = 100f;

	float calcHealth;

	float healthPercentage;

	public Image healthBar;
	public Text healthText;

	public Text plasmaGunPickedUpText;


	void Start () 
	{
		currentPlayerHealth = maxPlayerHealth;
	}


	void FixedUpdate () 
	{		
		PlayerHP ();
		SetPlayerFlashLight ();
	}

	void Update()
	{

	}

	void OnTriggerEnter(Collider other)
	{
		//AI
		//If The Player Is Attacked By The Wolf, Do Damage
		if (other.gameObject.tag == "Wolf")
		{
			currentPlayerHealth = currentPlayerHealth - 10f;
		}

		//If The Player Is Attacked By The Boss Wolf, Do Damage
		if (other.gameObject.tag == "BossWolf")
		{
			currentPlayerHealth = currentPlayerHealth - 20f;
		}

		//If The Player Is Hit By Snake Venom, Do Damage
		if (other.gameObject.tag == "SnakeVenom")
		{
			currentPlayerHealth = currentPlayerHealth - 15f;
			Destroy (other.gameObject);
		}

		//Pick Up Ammo Pack when walked over
		if (other.gameObject.tag == "BulletPack")
		{
			GameController.GetComponent<AmmoController>().BulletPackPickup();
			Destroy (other.gameObject);
		}

		//Pick Up Health Pack when walked over
		if (other.gameObject.tag == "HealthPack")
		{
			currentPlayerHealth += 10f;
			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "PlasmaGun")
		{
			weaponSlot.GetComponent<WeaponSwapController>().PlasmaGunPickedUp();
			Destroy (other.gameObject);
			plasmaGunPickedUpText.text = "Plasma Gun Equipped";
			PlasmaGunPickUpTextGO.GetComponent<SelfDestructUIText>().SelfDestruct();

		}

	}

	void PlayerHP ()
	{
		calcHealth = currentPlayerHealth / maxPlayerHealth;
		SetHealthBar(calcHealth);

		float healthPercentage= currentPlayerHealth / maxPlayerHealth * 100f;
		healthText.text = healthPercentage + "%";

		if (currentPlayerHealth >= maxPlayerHealth)
			currentPlayerHealth = maxPlayerHealth;

		if (currentPlayerHealth <= 0)
			Destroy(this.gameObject);

	}

	//Display Health on bar

	public void SetHealthBar (float myHealth)
	{
		healthBar.fillAmount = myHealth;
	}

	public void SetPlayerFlashLight()
	{
		if (Input.GetKeyDown (KeyCode.F) && playerFlashLightEnabled == false)
		{
			playerFlashLight.SetActive (true);
			playerFlashLightEnabled = true;
		}
			
		else if (Input.GetKeyDown (KeyCode.F) && playerFlashLightEnabled == true) 
		{
			playerFlashLight.SetActive(false);
			playerFlashLightEnabled = false;
		}

	}
}
