using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPush : MonoBehaviour {
	public GameObject cave;
	public AudioClip caveRot;
	AudioSource button_audio;
	int rotCount;
	public bool cave_is_rotate = false;
	GameObject[] stones ;
	//Animator anim;

	// Use this for initialization
	void Start () {
		button_audio = GetComponent<AudioSource>();
		rotCount = 1;
		Debug.Log ("button_push starts");
	
		//anim = GetComponent<Animator>();
		//anim.SetBool ("stop", false);
	}
	
	// Update is called once per frame
	void Update () {

		if (cave_is_rotate) {
			/*if (Input.GetKeyDown (KeyCode.C)) {
				rotCount = 110;
			}*/
			if (rotCount < 250) {
				cave.transform.Rotate (0, Time.deltaTime * 25, 0);
				rotCount = rotCount + 1;
			} else {
				button_audio.Pause ();
			}
		}
	}

	void OnCollisionEnter(Collision col){
		stones = GameObject.FindGameObjectsWithTag("killer_rock_breakage");
		if (col.collider.gameObject.tag == "Player" && stones != null) {//|| col.collider.name == "shadowEmpty") {
			//anim.SetBool("stop", true);
			cave_is_rotate = true;
			aiattack.cave_attack = true;
			button_audio.PlayOneShot (caveRot, 2f);
		}
	}
}
