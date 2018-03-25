using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour {
	public int ele_count=0;
	public int ele_low=0;
	public int ele_high=0;
	
	// Update is called once per frame
	// elevetors: 1: 6-12; 2:10-16; 3: 14-20; 4:18-26
	void Update () {
		if (ele_count >= 0 && ele_count < 150) {
			transform.Translate (0, Time.deltaTime * 2, 0);
			ele_count = (ele_count + 1) % 300;
			if (transform.position.y > ele_high) {
				ele_count = 150;
			}
		} else {
			transform.Translate (0, -Time.deltaTime * 2, 0);
			ele_count = (ele_count + 1) % 300;
			if (transform.position.y < ele_low) {
				ele_count = 0;
			}
		}
	}
}
