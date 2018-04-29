using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
	public bool swap = false;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (swap == false) {
			transform.Rotate (0, 0, -10 * Time.deltaTime);
		}
		if (swap == true) {
			transform.Rotate (0, 0, 10 * Time.deltaTime);
		}
	}

	// The rotate swaps
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "bounce") {
			swap = false;
		}
		if (other.gameObject.tag == "bounce2") {
			swap = true;
		}
	}
}
