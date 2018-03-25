using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caibin_trigger : MonoBehaviour {
	
	public GameObject leepy_new;
	public GameObject leepy_old;
	private AudioSource Level;
	public AudioClip level_pop;
	private bool level_triggered;

	void Start(){
		level_triggered = false;
		leepy_new.SetActive (false);
		Level = GetComponent<AudioSource> ();
	}
		
	void OnCollisionEnter(Collision col){
		if (!level_triggered && col.gameObject.tag == "Player") {
			Debug.Log ("shadow hitting elevator trigger points");
			leepy_old.SetActive (false);
			leepy_new.SetActive (true);
			Level.PlayOneShot (level_pop, 1f);
			buggy_leppy.speed = 3.0f;
			buggy_leppy.start = true;
			level_triggered = true;
			}
		}
	}
