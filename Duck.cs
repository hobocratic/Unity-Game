﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Ducking
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			transform.gameObject.tag = "duck";
		} 

	}
}
