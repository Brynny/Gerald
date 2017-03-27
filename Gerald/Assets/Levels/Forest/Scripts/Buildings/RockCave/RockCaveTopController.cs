using UnityEngine;
using System.Collections;

public class RockCaveTopController : MonoBehaviour 
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
