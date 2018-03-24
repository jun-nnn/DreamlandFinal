using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect_snowman : MonoBehaviour {
	public xiaodouDeath die_script;
	public Transform respawnPoint;
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "snowball") {
			Debug.Log ("snowball hit Leepy");
			StartCoroutine(die_script.TakeDamageAndRespawn(respawnPoint));
		}
	}
}
