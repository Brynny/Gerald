using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour 
{

	public float currentPlayerHealth = 100f;
	public float maxPlayerHealth = 100f;

	float calcHealth;

	float healthPercentage;

	public Image healthBar;

	void Start () 
	{
	
	}
	

	void FixedUpdate () 
	{		
		PlayerHP();
		SetHealthBar(calcHealth);
	}

	void OnTriggerEnter(Collider other)
	{
		//If The Player Is Attacked By The Wolf, DO Damage
		if(other.gameObject.tag == "Wolf")
		{
			currentPlayerHealth = currentPlayerHealth - 10f;
		}
	}

	void PlayerHP()
	{
		calcHealth = currentPlayerHealth - maxPlayerHealth;
		//Make Player Health A percentage
		healthPercentage = (currentPlayerHealth / maxPlayerHealth) * 100f; 
	}

	//Display Health on bar

	public void SetHealthBar (float myHealth)
	{
		healthBar.fillAmount = myHealth;
	}

}
