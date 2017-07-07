using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuriousController : MonoBehaviour {

	private Animator characterAnimController;
	private bool isJumping;

//	public float moveSpeed;
	public float jumpForce;

	void Awake () {
		characterAnimController = GetComponent<Animator> ();
	}
	
	void FixedUpdate () {
		MoveCurious ();
	}

	void MoveCurious () {
		//- Move left and right
		if (Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.A))
		{
			characterAnimController.SetBool ("isWalking", true);
			transform.Translate (Vector3.left * Time.deltaTime);
		} 
		else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D))
		{
			characterAnimController.SetBool ("isWalking", true);
			transform.Translate (Vector3.right * Time.deltaTime);
		}


		//- Jump
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) 
		{

			isJumping = true;
			characterAnimController.SetTrigger ("isJumping");

			transform.Translate (Vector3.up * Time.deltaTime * jumpForce);
		}
		else {
			isJumping = false;
		}
	}
}
