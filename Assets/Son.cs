using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] //This add the AudioSource component automatically.
public class Son : MonoBehaviour
{
	
	public AudioClip Sound; // Reference to the sound effect of the screamer.
	public string PlayerTag; //Reference to the tag of the player.
	public float SoundDuration = 1f; //Reference to the time duration of the sound effect of the screamer.

	private AudioSource audioSource; //Reference to the AudioSource component.

	void Awake() //Setup different things before starting the game.
	{
		audioSource = GetComponent<AudioSource>(); //identify the AudioSource component.
		audioSource.clip = Sound; //Assign the sound effect to the AudioSource component.
		audioSource.playOnAwake = false; //Disable the "Play on awake" parameterer because we don't want to play the screamer sound when starting the game.
		
	}

	void OnTriggerEnter(Collider col) //Detect if something enter in the collider
	{
		if (col.CompareTag(PlayerTag)) //Check if the player is in the collider, if no : nothing happen.
		{
			
			audioSource.Play(); //Play the sound effect of the screamer.
			StartCoroutine("WaitForRemove"); //Start a wait function.
		}
	}

	IEnumerator WaitForRemove() //This function is active only if called.
	{
		yield return new WaitForSeconds(SoundDuration); //Wait the duration determined in the inspector window.
		audioSource.clip = null; //Remove the sound effect of the AudioSource. It prevent to play the sound effect multiple times.
		
		Destroy(this); //Destroy the GameObject which contains this script because we don't need to trigger the screamer anymore.
	}
}