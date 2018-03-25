using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fix_bridge : MonoBehaviour {
	
	public GameObject bridge;
	private GameObject nextlevel; 
	private bool start_bridge_rotation;
	public float rotspeed = 2.0f;

	void Start(){
		start_bridge_rotation = false;
		nextlevel = GameObject.FindGameObjectWithTag ("bridge_trigger");
		nextlevel.SetActive (false);
	}
	/*
	void Update(){
		if(start_bridge_rotation && bridge.transform.rotation.z < 0.0){
			Debug.Log("now, trigger bridge movement");
			bridge.transform.rotation = Quaternion.Euler (0, 0, 0.0);
		}


	}
	*/
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			start_bridge_rotation = true;
			bridge.transform.Rotate (new Vector3 (0, 0, 20));
		}
	}
}
