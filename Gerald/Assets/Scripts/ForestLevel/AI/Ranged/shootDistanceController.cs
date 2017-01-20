using UnityEngine;
using System.Collections;

public class shootDistanceController : MonoBehaviour
{
	public GameObject weapon;
	public GameObject RangedAI;
	void Start () 
	{

	}


	void Update ()
	{

	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			RangedAI.GetComponent<rangedMovementController>().LootAtPlayer();
			weapon.GetComponent<rangedController>().Shoot();
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{

		}
	}
}