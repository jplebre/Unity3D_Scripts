using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class FootSteps : MonoBehaviour {
	public AudioClip metalFootstep;
	public AudioClip rockFootstep;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider myCollider){
		if(myCollider.gameObject.tag == "Metal Floor"){

			audio.PlayOneShot(metalFootstep);
		} else if (myCollider.gameObject.tag == "Gravel Floor") {
			audio.PlayOneShot (rockFootstep);
		}

	}
}
