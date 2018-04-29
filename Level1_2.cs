using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other) {
		// Triggers when the transparent sprite hits the correct tags
		if (other.gameObject.tag == "Player") {
			SceneManager.LoadScene ("Level_2");
		}
	}
}
