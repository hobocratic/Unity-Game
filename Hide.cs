using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour {

	public bool hide = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (hide == true) {
			if (Input.GetKeyDown(KeyCode.W)) {
				GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = true;
				GameObject.Find("Player").GetComponent<Duck>().enabled = true;
				GameObject.Find("Player").transform.Translate(-20, -20, 0);//6.47,-2.06,0
				hide = false;
			}
		}
	}


	void OnCollisionStay2D(Collision2D other) {
		if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E)) {
			GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
			GameObject.Find("Player").GetComponent<Duck>().enabled = false;
			GameObject.Find("Player").transform.Translate(20, 20, 0);//17,6,0
			hide = true;
		
		}
	}
}
