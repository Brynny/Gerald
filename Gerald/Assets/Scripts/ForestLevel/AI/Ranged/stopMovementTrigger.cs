using UnityEngine;
using System.Collections;

public class stopMovementTrigger : MonoBehaviour
{

	public GameObject rangedAI;
	bool canMove = true;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			rangedAI.GetComponent<rangedMovementController>().StopMovement();
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			rangedAI.GetComponent<rangedMovementController>().MoveToPlayer();
		}
	}
}