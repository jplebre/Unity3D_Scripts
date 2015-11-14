using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class JetPack : MonoBehaviour {
	public GameObject characterObject;
	public AudioClip jetPack;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)){
			audio.PlayOneShot (jetPack);
		}
		if (Input.GetKeyUp (KeyCode.Space)){
			audio.Stop ();
		}

		//CharacterController.PlatformController.IsJumping()

	}
}
