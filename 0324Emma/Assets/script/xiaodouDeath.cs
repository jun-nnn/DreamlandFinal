using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiaodouDeath : MonoBehaviour {
	public GameObject shadow_empty;

	private AudioSource shadow_audio;
	// audioclips
	public AudioClip uhoh;
	public static bool instant_respawn = true;
	public static bool isicelayer = true;
	public IEnumerator TakeDamageAndRespawn (Transform respawnPoint)
	{
		Debug.Log ("taking damage and respawning");
		game_logic.life_count -= 1;
		if (instant_respawn) {
			if (gameObject.GetComponent<Animator> () != null) {
				gameObject.GetComponent<Animator> ().SetTrigger ("death");
			}
			shadow_audio = GetComponent<AudioSource> ();
			if (shadow_audio != null) {
				shadow_audio.PlayOneShot (uhoh, 1F);
			}
			yield return new WaitForSeconds (1.5f);
			gameObject.transform.position = respawnPoint.transform.position;
			shadow_empty.transform.position = respawnPoint.transform.position;
			if(isicelayer) Application.LoadLevel (Application.loadedLevel);
		} else if (game_logic.life_count == 0) {
			gameObject.transform.position = respawnPoint.transform.position;
			shadow_empty.transform.position = respawnPoint.transform.position;
		}
	}
}
