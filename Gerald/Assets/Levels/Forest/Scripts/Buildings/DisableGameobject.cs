using UnityEngine;
using System.Collections;

public class DisableGameobject : MonoBehaviour 
{

	public void DisableObject()
	{
		gameObject.SetActive(false);
	}

	public void EnableObject()
	{
		gameObject.SetActive(true);
	}
}
