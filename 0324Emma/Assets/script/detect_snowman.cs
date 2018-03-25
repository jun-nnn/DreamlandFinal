using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect_snowman : MonoBehaviour {
	public AudioClip snowball_hit;
	private AudioSource snowball;
	public xiaodouDeath die_script;
	public Transform respawnPoint;

	void Start(){
		snowball = GetComponent<AudioSource> ();
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "snowball") {
			snowball.PlayOneShot (snowball_hit, 1.5F);
			Debug.Log ("snowball hit Leepy");
			StartCoroutine(die_script.TakeDamageAndRespawn(respawnPoint));
		}
	}
}
