using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icewallremove : MonoBehaviour {
	public GameObject icewall;
	public AudioClip icewall_remove;
	private AudioSource icewall_Remove;

	void Start(){
		icewall_Remove = GetComponent<AudioSource> ();
	}
	// Use this for initialization
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			icewall_Remove.PlayOneShot (icewall_remove, 1f);
			icewall.SetActive (false);	
		}
	}
}