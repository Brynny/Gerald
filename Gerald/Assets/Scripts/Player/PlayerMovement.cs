﻿using UnityEngine; 
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{

	public float moveSpeed = 6f;
	public float rotationSpeed = 30f;
	public float gravity = 200f;
	private Vector3 moveDirection = Vector3.zero;

	void Start ()
	{
	
	}

	void Update () 
	{
		Movement();
	}

	public void Movement()
	{
		CharacterController controller = GetComponent<CharacterController>();

		moveDirection = new Vector3 (0, 0, Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= moveSpeed;

		moveDirection.y -= gravity * Time.deltaTime;

		transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime));

		controller.Move(moveDirection * Time.deltaTime);
	}
}
