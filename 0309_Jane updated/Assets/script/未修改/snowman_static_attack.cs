using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowman_static_attack : MonoBehaviour {
	
	public GameObject projectile;
	private float timeBtwShots;
	public float startTimeBtwShot;
	public float lookingDistance;
	public float rotaiondamping;
	public Transform player;
	public Transform enemies;
	public bool start_leepy_attack;

	public void startLeepyAttack(){
		start_leepy_attack = true;
	}

	public void finishLeepyAttack(){
		start_leepy_attack = false;
	}

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("leepy").transform;
		timeBtwShots = startTimeBtwShot;
		start_leepy_attack = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Vector3.Distance(enemies.position, player.position) < lookingDistance){
			lookAtPlayer();
		}
		if (start_leepy_attack) {
			if (timeBtwShots <= 0) {
				Debug.Log ("start shooting");
				Instantiate (projectile, enemies.position, enemies.rotation);
				timeBtwShots = startTimeBtwShot;
			} else {
				timeBtwShots -= Time.deltaTime;
			}
		}
		
	}
		
	void lookAtPlayer(){
		Quaternion rotation = Quaternion.LookRotation(player.position - enemies.position);
		transform.rotation = Quaternion.Slerp(enemies.rotation, rotation, Time.deltaTime * rotaiondamping);
	}
}
