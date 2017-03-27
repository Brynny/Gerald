using UnityEngine;
using System.Collections;

public class WolfAlertController : MonoBehaviour
{
	public GameObject Ai;

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Ai.GetComponent<WolfMovementController>().MoveToPlayer();
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Ai.GetComponent<WolfMovementController>().StopMovement();
		}
	}
}
