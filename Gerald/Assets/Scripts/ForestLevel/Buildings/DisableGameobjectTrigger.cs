using UnityEngine;
using System.Collections;

public class DisableGameobjectTrigger : MonoBehaviour
{
	public GameObject disabledGameobject;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("HIT TRIGGER");
			disabledGameobject.GetComponent<DisableGameobject>().DisableObject();
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("LEFT TRIGGER");
			disabledGameobject.GetComponent<DisableGameobject>().EnableObject();
		}
	}
}
