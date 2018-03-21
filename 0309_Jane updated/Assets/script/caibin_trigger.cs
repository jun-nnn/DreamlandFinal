using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caibin_trigger : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			Debug.Log ("shadow hitting elevator trigger points");
			buggy_leppy.speed = 3.0f;
			buggy_leppy.start = true;
			}
		}
	}
