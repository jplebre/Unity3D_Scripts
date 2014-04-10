/* Based of Unity 4.x Cookbook script "CameraSwitch"
 * Create an empty object
 * Attach this script to empty object
 * Create as many cameras as you want
 * In the empty object with this script, tell the scripts how many cameras are in use
 * Drag the cameras into the Cameras slots created
 * How many keyboard keys do you want to allocate (usually no. cameras == no.keys)
 * Assign keyboard keys into camera control key (eg. 1, 2, 3, 4, 5)
 * Leave audio listener checked, unless you want the audio source to remain fixed.
 * 
 * Changes:
 * - Added a start statement that will ensure other cameras are not on.
 * - Added a start statement to ensure no other audio listeners are on.
 */


using UnityEngine;

public class CameraSwitchboard : MonoBehaviour
{
	//lets initiallise a few arrays for our GUI
	//public int numberOfCameras;

	public GameObject[] cameras;
	public string[] cameraControlKey;


	//The audio listener will have to be turned on for the active camera
	//Will have to be turned off for all inactive cameras
	public bool changeAudioListener = true;


	void Start()
	{
				SwitchCamera (0);
	}


	//Every frame check if player input any of the key
	void Update()
	{
		//Debug.Log(Input.GetKeyUp(KeyCode.Space));
		for (int i = 0; i < cameras.Length; i++)
		{
			if (Input.GetKeyUp(cameraControlKey[i]))
				SwitchCamera(i);
		}
	}

	void SwitchCamera (int index)
	{
		for (int i = 0; i<cameras.Length; i++)
		{
			if (i != index)
			{
				if (changeAudioListener)
				{cameras[i].GetComponent<AudioListener>().enabled = false;}
					//this is Unity Generic Function synthax function FuncName.<T>()
				cameras[i].camera.enabled = false;
			}
			else
			{
				if (changeAudioListener)
				{cameras[i].GetComponent<AudioListener>().enabled = true;}
				cameras[i].camera.enabled = true;
			}

		}
	}
}

