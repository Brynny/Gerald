using UnityEngine;
using System.Collections;

public class DisableGameobjectTrigger : MonoBehaviour
{
	public GameObject disabledGameobject;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			disabledGameobject.GetComponent<DisableGameobject>().DisableObject();
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			disabledGameobject.GetComponent<DisableGameobject>().EnableObject();
		}
	}
}
