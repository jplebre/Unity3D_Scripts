using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour
{
	public string tagIdentifier;
	public AudioClip audioFile;
	public float audioFileLevel;
	public bool destroyObject = false;

	void OnCollisionEnter(Collision whatHitUs)
	{

		if (whatHitUs.collider.CompareTag(tagIdentifier) )
		{
			Debug.Log("BANG!!");
		}
	}


	/*
	 * this is the rest of the code to implement when collision detection works.
	// If there is an animation attached.
	// Play it.
	if (animation && animation.clip)
	{
		animation.Play();
		if (destroy?)
		{
			Destroy(gameObject, animation.clip.length);
		}
	}
	else
	{
		if (destroy?)
			Destroy(gameObject);
	}
	
	
	
	void Start ()
	{	
	}
	
	void Update ()
	{	
	}
*/
}