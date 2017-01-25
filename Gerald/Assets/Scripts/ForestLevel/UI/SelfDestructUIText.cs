using UnityEngine;
using System.Collections;

public class SelfDestructUIText : MonoBehaviour 
{
	void FixedUpdate()
	{
		Object.Destroy(gameObject, 3f);
	}
}
