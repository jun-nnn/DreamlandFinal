using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over_finally : MonoBehaviour {
	public GameObject youwin;
	public GameObject snow;
	public GameObject shadow;
	public AudioClip win;
	//AudioSource shadow_dance;
	private Animator anim;
	//public GameObject cam;
	

	void Start(){
		
		anim = shadow.transform.GetChild (0).GetComponent<Animator> ();
		//shadow_dance = GetComponent<AudioSource>();

	}
		
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag =="leepy3"){
			snow.SetActive(true);
			Debug.Log("reach the cabin, you win!");
			//youwin.gameObject.SetActive (true);
			Debug.Log("output you win");
			anim.SetTrigger ("dance");
			//cam.GetComponent<AudioSource>().pause();
			shadow_dance.PlayOneShot(win,1F);
		}
	}
}
