using UnityEngine;
using System.Collections;

public class WolfBloodController : MonoBehaviour 
{

	void Awake ()
	{
		
	}

	void FixedUpdate () 
	{
		Object.Destroy(gameObject, 0.4f);
	}
}
