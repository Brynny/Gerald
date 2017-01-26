using UnityEngine;
using System.Collections;

public class SelfDestructUIText : MonoBehaviour 
{
	public void SelfDestruct()
	{
		Object.Destroy(gameObject, 3f);
	}
}
