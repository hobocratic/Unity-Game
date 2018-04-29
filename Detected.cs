using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detected : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Internet Solution for transparent GameObject
		SpriteRenderer spRend = gameObject.transform.GetComponent<SpriteRenderer>();
		Color col = spRend.color;
		col.a = 0.5f;
		spRend.color = col;
	}

	void OnTriggerStay2D(Collider2D other) {
		// Triggers when the transparent sprite hits the correct tags
		if (other.gameObject.tag == "Player") {
			SceneManager.LoadScene ("GameOver");
		}
	}
		
}

