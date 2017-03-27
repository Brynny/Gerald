using UnityEngine;
using System.Collections;

public class EncounterText : MonoBehaviour
{
	void FixedUpdate()
	{
		Object.Destroy(gameObject, 10f);
	}
}
