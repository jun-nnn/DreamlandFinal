using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sbattack : MonoBehaviour {
	public GameObject snowball;
	private float timeBtwShots;
	public float startTimeBtwShot;
	public float lookingDistance;
	public float attackDistance;
	public float rotate_speed;
	public Transform player;
	public static bool start_leepy_attack;


	// Use this for initialization
	void Start () {
		timeBtwShots = startTimeBtwShot;
		start_leepy_attack = false;
	}

	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (transform.position, player.position) < lookingDistance) {
			lookAtPlayer ();
			Debug.Log ("start loking at leepy");

			if (Vector3.Distance (transform.position, player.position) < attackDistance) {
				Debug.Log ("start att leepy");
				if (start_leepy_attack) {
					if (timeBtwShots <= 0) {
						Debug.Log ("snowball shoots");
						Instantiate (snowball, transform.position, transform.rotation);
						timeBtwShots = startTimeBtwShot;
					} else {
						timeBtwShots -= Time.deltaTime;
					}
				}
			}
		}

	}

	public void lookAtPlayer(){
		Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
		this.transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotate_speed);
	}

	/*
	public void startLeepyAttack(){
		start_leepy_attack = true;
	}

	public void finishLeepyAttack(){
		start_leepy_attack = false;
	}
	*/
}
