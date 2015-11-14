using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class MusicManager : MonoBehaviour {
	public AudioClip[] musicFiles;
	public bool loopMusic = true;

	AudioClip audiofile;



	// Use this for initialization
	void Start () {  
		audio.loop = true;
		audio.volume = 1.0f;
		audio.clip = musicFiles[0];
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void play(int musicCue, float musicLevel){
		audio.clip = musicFiles[musicCue];
		audio.volume = musicLevel;
		audio.Play();
	}

	public void stop(){
		audio.Stop();		//musicManager.GetComponent<MusicManager>().play(1);

	}
}
