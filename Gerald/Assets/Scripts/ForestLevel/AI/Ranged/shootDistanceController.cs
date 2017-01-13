using UnityEngine;
using System.Collections;

public class shootDistanceController : MonoBehaviour
{
	public GameObject weapon;
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