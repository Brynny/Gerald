using UnityEngine;
using System.Collections;

public class WolfMovementController : MonoBehaviour
{
	public Transform target;
	public GameObject Wolf;

	private UnityEngine.AI.NavMeshAgent agent;


	void Start () 
	{
		agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
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
