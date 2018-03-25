using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowman_attack_trigger : MonoBehaviour {
	private GameObject nextlevel;		
	private AudioSource Level;
	private bool level_triggered;

	public AudioClip level_pop;

	// Use this for initialization
	void Start(){
		level_triggered = false;
		Level = GetComponent<AudioSource> ();
		nextlevel = GameObject.FindGameObjectWithTag ("icewall_trigger");
		nextlevel.SetActive (false);
		leepyPath.start = false;
		sbattack.start_leepy_attack = false;
		xiaodouDeath.instant_respawn = true;
		xiaodouDeath.isicelayer = true;
	}
	void OnCollisionEnter(Collision col){
		if (!level_triggered && col.gameObject.tag == "Player") {
			Debug.Log ("shadow hitting trunk trigger points");
			Level.PlayOneShot (level_pop, 0.5F);
			leepyPath.speed = 3.0f;
			leepyPath.start = true;
			sbattack.start_leepy_attack = true;
			xiaodouDeath.instant_respawn = false;
			xiaodouDeath.isicelayer = false;
			level_triggered = true;
			gameObject.SetActive (false);
			nextlevel.SetActive (true);
		}
	}
}
