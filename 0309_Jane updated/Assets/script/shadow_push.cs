using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadow_push : MonoBehaviour {

	// Use this for initialization
	void OncolliderEnter(Collision c){
		float force = 1.0f;
		if (c.gameObject != null) {
			Vector3 dir = c.contacts [0].point - transform.position;
			dir = dir.normalized;
			GetComponent<Rigidbody> ().AddForce (dir * force);
		}
	}
}
