using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	// Variables
	public float speed = 7f;


	// Use this for initialization
	void Start () {
	}
		
	// Update is called once per frame
	void Update () {
		// Movement
		if (Input.GetKey (KeyCode.S)) {
			transform.position += Vector3.down * Time.deltaTime * speed;
			speed = 5f;
			transform.gameObject.tag = "Player";
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.position += Vector3.up * Time.deltaTime * speed;
			speed = 5f;
			transform.gameObject.tag = "Player";
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += Vector3.left * Time.deltaTime * speed;
			speed = 7f;
			transform.gameObject.tag = "Player";
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += Vector3.right * Time.deltaTime * speed;
			speed = 7f;
			transform.gameObject.tag = "Player";
		}
		// Solution for double speed diagonal movement
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.D)) {
			speed = 4f;
		}
	

	}
}
