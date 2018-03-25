using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadowCamera : MonoBehaviour {
	//private CharacterController controller;
	//public float speed;
	public GameObject shadowEmpty;
	static int level = 1;
	static Vector3 currentpos;
	Vector3 pos1;
	Vector3 pos2;
	Vector3 pos3;

	// Use this for initialization
	void Start () {
		//controller = GetComponent<CharacterController>();
		pos1 = new Vector3 (18, 5, 0); // level 1 position
		pos2 = new Vector3 (-6, 5, 12); // level 3 position
		pos3 = new Vector3 (16, 3, 0); // level 2 position
		currentpos = pos1;
		// (0,-232,0) (0,270,0) (51,3,37)(57,-1,25)
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A) || level == 3) {
			currentpos = pos2;
			Vector3 rotation = new Vector3 (0, 500, 0);
			Quaternion deltaRotation = Quaternion.Euler (rotation);
			transform.rotation = deltaRotation;
		}
		if (level == 2) {
			currentpos = pos3;
		}
		transform.position = shadowEmpty.GetComponent<CharacterController>().transform.position + currentpos; //(75,3,25)(57,-1,25)
	}

	public static void change(){
		level = 3;
	}

	public static void lower(){
		level = 2;
	}
}
