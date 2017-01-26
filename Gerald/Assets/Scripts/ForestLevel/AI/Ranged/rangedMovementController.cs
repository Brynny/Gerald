using UnityEngine;
using System.Collections;

public class rangedMovementController : MonoBehaviour 
{
	public float rangedHealth = 20f;
	public GameObject Blood;

	public GameObject gameController;

	public Transform target;

	private NavMeshAgent agent;

	float dropRate = 0.5f;
	public GameObject[] Loot;


	void Start () 
	{
		agent = gameObject.GetComponent<NavMeshAgent>();
	}


	void FixedUpdate ()
	{
		RangedDeath();
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
			rangedHealth = rangedHealth - 2f;
			Instantiate (Blood, transform.position, transform.rotation);
		}

		if(other.gameObject.tag == "Plasma")
		{
			Destroy (other.gameObject);
			rangedHealth = rangedHealth - 4f;
			Instantiate (Blood, transform.position, transform.rotation);
		}
	}

	void RangedDeath()
	{
		if (rangedHealth <= 0)
		{
			if (Random.Range(0f, 1f) <= dropRate)
			{
				Instantiate (Loot[Random.Range(0, 2)], transform.position, Quaternion.identity);
			}
			gameController.GetComponent<GameController>().EnemyCount();
			Destroy (this.gameObject);
		}
	}

	public void LookAtPlayer()
	{
		if (target != null)
		{
			transform.LookAt(target);
		}
	}
}
