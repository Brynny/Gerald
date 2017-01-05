using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour 
{
	public GameObject Gun;

	public float currentPlayerHealth = 0f;
	public float maxPlayerHealth = 100f;

	float calcHealth;

	float healthPercentage;

	public Image healthBar;
	public Text healthText;

	void Start () 
	{
		currentPlayerHealth = maxPlayerHealth;
	}


	void FixedUpdate () 
	{		
		PlayerHP();
	}

	void OnTriggerEnter(Collider other)
	{
		//If The Player Is Attacked By The Wolf, DO Damage
		if (other.gameObject.tag == "Wolf")
		{
			currentPlayerHealth = currentPlayerHealth - 10f;
		}

		if (other.gameObject.tag == "BulletPack")
		{
			Gun.GetComponent<Ak47Controller>().BulletPackPickup();
			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "HealthPack")
		{
			currentPlayerHealth += 10f;
			Destroy (other.gameObject);
		}
	}

	void PlayerHP ()
	{
		calcHealth = currentPlayerHealth / maxPlayerHealth;
		SetHealthBar(calcHealth);

		float healthPercentage= currentPlayerHealth / maxPlayerHealth * 100f;
		healthText.text = healthPercentage + "%";
	}

	//Display Health on bar

	public void SetHealthBar (float myHealth)
	{
		healthBar.fillAmount = myHealth;
	}

}
