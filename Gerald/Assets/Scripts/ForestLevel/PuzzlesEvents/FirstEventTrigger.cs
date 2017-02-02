using UnityEngine;
using System.Collections;

public class FirstEventTrigger : MonoBehaviour 
{
	public GameObject TreesGO;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			TreesGO.GetComponent<FirstEventTreesActivation>().DisableTrees();
		}
	}

}
