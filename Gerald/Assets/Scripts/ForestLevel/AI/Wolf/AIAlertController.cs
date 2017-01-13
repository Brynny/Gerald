using UnityEngine;
using System.Collections;

public class AIAlertController : MonoBehaviour
{
	public GameObject Ai;

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Ai.GetComponent<AIMovementController>().MoveToPlayer();
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Ai.GetComponent<AIMovementController>().StopMovement();
		}
	}
}
