using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator_trigger : MonoBehaviour {
	public GameObject ele;
	// Use this for initialization
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			Debug.Log("now,trigger elevator");
			ele.SetActive(true);
		}
	}
}
