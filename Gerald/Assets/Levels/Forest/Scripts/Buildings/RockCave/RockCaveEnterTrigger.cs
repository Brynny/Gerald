using UnityEngine;
using System.Collections;

public class RockCaveEnterTrigger : MonoBehaviour 
{
	public GameObject rockCaveTop;


	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Player")
		{
			rockCaveTop.GetComponent<RockCaveTopController>().DisableObject();
		}
	}
}
