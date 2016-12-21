using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public float playerHealth = 100f;

	void Start () 
	{
	
	}
	

	void Update () 
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Wolf")
		{
			playerHealth = playerHealth - 10f;
		}
	}
}
