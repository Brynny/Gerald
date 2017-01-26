using UnityEngine;
using System.Collections;

public class rangedAlertController : MonoBehaviour 
{
	public GameObject rangedAI;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			rangedAI.GetComponent<rangedMovementController>().MoveToPlayer();
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			rangedAI.GetComponent<rangedMovementController>().StopMovement();
		}
	}
}
