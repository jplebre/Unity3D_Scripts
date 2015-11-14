using UnityEngine;
using System.Collections;

public class MusicTrigger : MonoBehaviour {
	GameObject musicManager;
	public int musicCueNumber;
	public float musicLevel = 1.0f;

	// Use this for initialization
	void Start () {
		musicManager = GameObject.Find ("MusicManager");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider myCollider){
		if (myCollider.name == "Character (Lerpz)"){
			musicManager.GetComponent<MusicManager>().stop();
			musicManager.GetComponent<MusicManager>().play(musicCueNumber, musicLevel);

		}
	}

}
