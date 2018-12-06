using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed; 
	public float JumpHeight;
	private bool DoubleJump;

	// Player grounded variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	//Non-Stick Player
	private float MoveVelocity;

	public Animator Animator;

	// Use this for initialization
	void Start () {
		Animator.SetBool("IsWalking", false);
	}
	

	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
		
	// Update is called once per frame
	void Update () {

		//This code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}

		//Double jump code
		if(Grounded){
				DoubleJump = false;
			Animator.SetBool("IsJumping", false);
		}
		

		if(Input.GetKeyDown (KeyCode.Space)&& !DoubleJump && !Grounded){
			Jump();
			DoubleJump = true;
		}

		//Non-Stick Player
		MoveVelocity = 0f;

		//this code makes the character move from side to side using the A&D keys
		if(Input.GetKey (KeyCode.D)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			MoveVelocity = MoveSpeed;
			Animator.SetBool("IsWalking", true);
		}
		else if (Input.GetKeyUp(KeyCode.D)){
			Animator.SetBool("IsWalking", false);
		}
	
		if(Input.GetKey (KeyCode.A)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			MoveVelocity = -MoveSpeed;
			Animator.SetBool("IsWalking", true);
		}
		else if (Input.GetKeyUp(KeyCode.A)){
			Animator.SetBool("IsWalking", false);
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);

		//player flip
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(.68f, .68f, .13f);

		else if (GetComponent<Rigidbody2D>().velocity.x <0)
			transform.localScale = new Vector3(-.68f, .68f, .13f);

	}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
		Animator.SetBool("IsJumping", true);
	}
}
