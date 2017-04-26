using UnityEngine;
using System.Collections;

public class MiniMapCameraController : MonoBehaviour
{
	public Transform player;
	public float distance = 200f;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		//transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - distance);

		Vector3 playerPosition = GameObject.Find("Player").transform.transform.position;
		GameObject.Find("MiniMapCamera").transform.position = new Vector3(playerPosition.x, playerPosition.y + distance, playerPosition.z);
	}
}
