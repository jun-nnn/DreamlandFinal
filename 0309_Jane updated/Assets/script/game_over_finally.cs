using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over_finally : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEter(Collider other){
		if(other.gameObject.tag =="leepy"){
			Debug.Log("reach the cabin, you win!");
			// TO DO : add game over effect
		}
	}
}
