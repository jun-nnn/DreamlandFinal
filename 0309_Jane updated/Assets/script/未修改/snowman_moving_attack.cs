using System.Collections;
using UnityEngine;

public class snowman_moving_attack : MonoBehaviour {

	public float snow_man_speed;
	public float stopDistance;
	public Transform player;
	public float rotaiondamping;

	void Start(){
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void Update(){

		if (Vector3.Distance (transform.position, player.position) > stopDistance) {
			transform.position = this.transform.position;
		} else if (Vector3.Distance (transform.position, player.position) < stopDistance) {
			lookAtPlayer ();
			transform.position = Vector3.MoveTowards (transform.position, player.position, snow_man_speed * Time.deltaTime);
		}
			
	}

	void lookAtPlayer(){
		
		Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotaiondamping);
	}
	
}
