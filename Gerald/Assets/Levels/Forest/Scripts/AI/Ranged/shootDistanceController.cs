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
			RangedAI.GetComponent<rangedMovementController>().LookAtPlayer();
			weapon.GetComponent<rangedController>().Shoot();
		}
	}
}