using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator3 : MonoBehaviour {
	public int ele3_count = 1;
	public bool reached = false;
	public static bool elevator_move = true;

	// Use this for initialization
	void Start () {
		//count = 160;
	}

	// Update is called once per frame
	void Update () {
		if (elevator_move) {
			if (ele3_count >= 1 && ele3_count < 205) {
				transform.Translate (0, Time.deltaTime * 6, 0);
				ele3_count = ele3_count + 1;
			} else if (ele3_count >= 205 && ele3_count < 350) {
				transform.Translate (0, 0, -Time.deltaTime * 6);
				ele3_count = ele3_count + 1;
			} else if (ele3_count >= 350 && ele3_count < 380) {
				transform.Translate (-Time.deltaTime * 6, 0, 0);
				ele3_count = ele3_count + 1;
			} 
		}
	}
}
