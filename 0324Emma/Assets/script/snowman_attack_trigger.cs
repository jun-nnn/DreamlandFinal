using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowman_attack_trigger : MonoBehaviour {
	private GameObject nextlevel;		
	public AudioSource Level;
	public AudioClip level_pop;
	public bool level_triggered;

	// Use this for initialization
	void Start(){
		level_triggered = false;
		Level = GetComponent<AudioSource> ();
	}
	void OnCollisionEnter(Collision col){
		if (level_triggered && col.gameObject.tag == "Player") {
			Debug.Log ("shadow hitting trunk trigger points");
			Level.PlayOneShot (level_pop, 1F);
			leepyPath.speed = 3.0f;
			leepyPath.start = true;
			sbattack.start_leepy_attack = true;
			xiaodouDeath.instant_respawn = false;
			xiaodouDeath.isicelayer = false;
			//gameObject.SetActive (false);
		}
	}
}
