using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour {

	public float speed;
	public float angularSpeed;

	private Rigidbody2D rb;

	void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate(){
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		float speedMultiplier = speed + (y * speed); 
		rb.velocity = -transform.up * speedMultiplier;

		rb.angularVelocity = -x * angularSpeed + speedMultiplier * 30 * -x;
	}

}
