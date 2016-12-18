using UnityEngine;
using System.Collections;

public class AIMovementController : MonoBehaviour
{
	public Transform target;

	private NavMeshAgent agent;


	void Start () 
	{
		agent = gameObject.GetComponent<NavMeshAgent>();
	}
	

	void FixedUpdate ()
	{
		
	}

	public void MoveToPlayer()
	{
		agent.SetDestination(target.position);
	}

	public void StopMovement()
	{
		agent.ResetPath();
	}
}
