using UnityEngine;
using System.Collections;

public class FirstEventTreesActivation : MonoBehaviour
{

	// Use this for initialization
	void Start () 
	{
		gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void DisableTrees()
	{
		gameObject.SetActive(true);
	}
}
