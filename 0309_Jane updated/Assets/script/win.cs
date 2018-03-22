using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour {
	public GameObject youwin;
	// Use this for initialization
	void Start () {
		youwin.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "leepy3" ){//|| col.collider.name == "shadowEmpty") {
			//button_audio.PlayOneShot (caveRot, 2.5f);
			youwin.gameObject.SetActive (true);
		}
	}
}
