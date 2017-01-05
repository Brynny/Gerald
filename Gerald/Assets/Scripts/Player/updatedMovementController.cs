using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class updatedMovementController : MonoBehaviour 
{
	public float moveSpeed;
	private Rigidbody myRB;

	private Vector3 moveInput;
	private Vector3 moveVelocity;

	private Camera mainCamera;


	void Start ()
	{
		myRB = GetComponent<Rigidbody>();
		mainCamera = FindObjectOfType<Camera>();
	}
	

	void Update () 
	{
		
	}

	void FixedUpdate()
	{
		Movement();
	}

	void Movement()
	{
		moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput * moveSpeed;

		myRB.velocity = moveVelocity;

		Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
		Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
		float rayLength;

		if (groundPlane.Raycast(cameraRay, out rayLength))
		{
			Vector3 pointToLook = cameraRay.GetPoint(rayLength);
			Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

			transform.LookAt(pointToLook);
		}
	}
		
}
