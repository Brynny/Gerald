using UnityEngine;
using System.Collections;

public class explosionController : MonoBehaviour
{
	void FixedUpdate () 
	{
		Object.Destroy(gameObject, 0.01f);
	}
}
