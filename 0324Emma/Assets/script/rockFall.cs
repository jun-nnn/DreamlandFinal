﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockFall : MonoBehaviour {

	
	// Update is called once per frame
	/*
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			GetComponent<Animator>().SetTrigger("move");
		}
		
	}*/

	void  OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			Debug.Log ("touch the rock");
			gameObject.GetComponent<Rigidbody>().isKinematic = false;
		}
	}
}
