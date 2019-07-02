using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//Update gets called before rendering a frame
	//Where most of your game code will go
	// void Update(){

	// }

	public float speed;

	private Rigidbody rb;

	//Gets called on first frame. Normally gets called first.
	void Start(){
		 rb = GetComponent<Rigidbody>();
	}

	//Called right before any physics calculation
	//Where our physics code will go   
	//Moving body by applying rigid force, which is physics
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
	}
}
