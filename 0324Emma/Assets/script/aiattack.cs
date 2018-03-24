using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiattack : MonoBehaviour {
	Animator anim;
	string state = "patrol";
	public GameObject[] waypoints;
	public float accuracy = 4.0f;
	public float rot_speed = 1.0f;
	public float speed =0.5f;
	int Current_pos = 0;
	public float chase_distance = 2.0f;
	public static bool cave_attack = true;

	// Use this for initialization
	void Start () {
		for (int Current_pos = 0; Current_pos < waypoints.Length; Current_pos++) {
			if (state == "patrol" && waypoints.Length > 0 && cave_attack) {
				Debug.Log ("cave attack");
				this.transform.position = Vector3.MoveTowards (transform.position, waypoints [Current_pos].transform.position, Time.deltaTime * speed);
				if (Current_pos == 5)
					Current_pos = 0;
			}
		}
	}
	
	// Update is called once per frame
	void StartAttack ()
	{
	}
}

