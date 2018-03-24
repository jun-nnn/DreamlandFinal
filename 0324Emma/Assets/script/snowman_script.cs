﻿using UnityEngine;
using System.Collections;

public class snowman_script : MonoBehaviour {

	private AudioSource snowman_audio;
	private Vector3 currPos;
	private Vector3 currRot;
	private Vector3 targetPos = new Vector3(31.83f, -0.3331741f, -22.53f);
	private Vector3 targetRot = new Vector3(17.757f, 29.842f, 1.548f);
	private GameObject icewall;
	private AudioSource icewallPop;
	private AudioSource stone;

	public AudioClip sink;
	public GameObject rock_breakages;
	public AudioClip stone_break;
	public AudioClip icewall_pop;

	float time = 0;
	bool should_sink;

	void Start(){

		//GetComponent<AudioSource> ().clip = sink;
		should_sink = false;
		currPos = transform.position;
		currRot = transform.eulerAngles;
		snowman_audio = GetComponent<AudioSource> ();
		stone = GetComponent<AudioSource>();
		Debug.Log ("snowman_script starts");
		icewall = GameObject.FindGameObjectWithTag ("icewall");
		icewall.SetActive (false);
		icewallPop = GetComponent<AudioSource> ();
	}

	void Update() {
		if (gameObject.transform.position == targetPos) {
			Debug.Log ("Snowman should stop sinking");
			should_sink = false;
			gameObject.GetComponent<Animator>().enabled = false;
		
			return;
		}
		if (should_sink) {
			Debug.Log ("Snowman sinking");
			//shadow_audio = GetComponent<AudioSource> ();
			//snowman_audio.PlayOneShot (sink, 0.05f);
			time += Time.deltaTime / 0.5f; //sink for 5 seconds
			currPos = Vector3.Lerp (currPos, targetPos, time);
			currRot = new Vector3 (
				Mathf.LerpAngle (currRot.x, targetRot.x, time * 0.1f),
				Mathf.LerpAngle (currRot.y, targetRot.y, time * 0.1f),
				Mathf.LerpAngle (currRot.z, targetRot.z, time * 0.1f));
		}
		transform.SetPositionAndRotation(currPos, Quaternion.Euler(currRot));
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "killer_rock") {
			Debug.Log ("Snowman killed");
			//snowman_audio.PlayOneShot (sink, 0.05f);
			other.gameObject.SetActive (false);

			rock_breakages.GetComponent<break_rock> ().BreakRock ();
			stone.PlayOneShot (stone_break, 1f);
			icewallPop.PlayOneShot (icewall_pop, 1f);
			sbattack.start_leepy_attack = false;
			should_sink = true;
			icewall.SetActive (true);
		}
	}
}