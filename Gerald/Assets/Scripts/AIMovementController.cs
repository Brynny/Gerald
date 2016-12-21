using UnityEngine;
using System.Collections;

public class AIMovementController : MonoBehaviour
{
	public Transform target;
	float damage;
	public GameObject Wolf;

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

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Bullet")
		{
			Destroy (other.gameObject);
		}
	}
}
