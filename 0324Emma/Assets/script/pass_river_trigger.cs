using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pass_river_trigger : MonoBehaviour {
	
	public float waitTime;
	public AudioClip ice_pop;
	public AudioClip level_pop;
	public bool level_triggered;

	private GameObject[] ice = new GameObject[5];
	private GameObject next_level;
	private AudioSource Level;
	private AudioSource icePop;

	// Use this for initialization
	void Start () {
		
		level_triggered = false;
		icePop = GetComponent<AudioSource> ();
		Level = GetComponent<AudioSource> ();
		next_level = GameObject.FindGameObjectWithTag ("walk_to_trunk");
		next_level.SetActive (false);

		for(int i =0;i<5;i++){
			ice[i] = GameObject.FindGameObjectWithTag("ice"+ i.ToString());
			ice[i].SetActive(false);
			Debug.Log ("make ice invisible");

		}
	}
	
	// Update is called once per frame
	IEnumerator LateCall(){
		for (int i = 4; i >= 0; i--) {
			icePop.PlayOneShot (ice_pop, 0.6F);
			ice [i].SetActive (true);
			yield return new WaitForSeconds (waitTime);
		}
		gameObject.SetActive (false);
		next_level.SetActive (true);

	}
	
		//StopCoroutine ("Enter new challenge");}

	void OnCollisionEnter(Collision col){
		if (!level_triggered && col.gameObject.tag == "Player") {
			Debug.Log ("pass river trigger");
			PlayerPrefs.GetInt ("current_scene", Application.loadedLevel);
			Level.PlayOneShot (level_pop, 0.5F);
			StartCoroutine (LateCall());
			xiaodouDeath.isicelayer = true;
			level_triggered = true;
		}
	}
}
