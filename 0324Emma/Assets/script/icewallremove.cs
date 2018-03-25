using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icewallremove : MonoBehaviour {
	public GameObject icewall;
	public AudioClip icewall_remove;
	private AudioSource icewall_Remove;
	private bool level_triggered;

	void Start(){
		level_triggered = false;
		icewall_Remove = GetComponent<AudioSource> ();
	}
	// Use this for initialization
	void OnCollisionEnter(Collision col){
		if (!level_triggered && col.gameObject.tag == "Player") {
			icewall_Remove.PlayOneShot (icewall_remove, 1f);
			icewall.SetActive (false);	
			level_triggered = true;
		}
	}

	void Update(){
		if (level_triggered)
			gameObject.SetActive (false);
	}
		
}