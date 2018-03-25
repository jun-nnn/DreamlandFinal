using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPush : MonoBehaviour {
	public GameObject cave;
	public AudioClip caveRot;
	AudioSource button_audio;
	int rotCount = 0;
	private float totalRot = 0;
	//Animator anim;

	// Use this for initialization
	void Start () {
		button_audio = GetComponent<AudioSource>();
		//anim = GetComponent<Animator>();
		//anim.SetBool ("stop", false);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			rotCount = 240;
		}
		if (totalRot <= 110 && rotCount >= 1 && rotCount < 240) {
			float thisrot = Time.deltaTime * 25;
			cave.transform.Rotate (0, thisrot, 0);
			totalRot += thisrot;
			print(totalRot);
			rotCount = rotCount + 1;
		} else {
			button_audio.Pause();
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.collider.gameObject.tag == "Player") {
			//anim.SetBool("stop", true);
			rotCount += 1;
			button_audio.PlayOneShot (caveRot, 2.5f);
			shadowCamera.lower();
		}
	}
}
