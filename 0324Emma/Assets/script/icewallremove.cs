using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icewallremove : MonoBehaviour {
	public GameObject icewall;
	public AudioClip icewall_remove;
	private AudioSource icewall_Remove;
	public AudioClip level_pop;
	private AudioSource Level;

	private bool level_triggered;

	void Start(){
		Level = GetComponent<AudioSource> ();
		level_triggered = false;
		icewall_Remove = GetComponent<AudioSource> ();
	}
	// Use this for initialization
	void OnCollisionEnter(Collision col){
		if (!level_triggered && col.gameObject.tag == "Player") {
			icewall_Remove.PlayOneShot (icewall_remove, 1f);
			Level.PlayOneShot (level_pop, 0.5F);
			icewall.SetActive (false);	
			level_triggered = true;
		}
	}
}