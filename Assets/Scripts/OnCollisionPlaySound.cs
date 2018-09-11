using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionPlaySound : MonoBehaviour {
	public AudioClip Clip;

	public void OnCollisionEnter(Collision collision) {
		AudioSource.PlayClipAtPoint(Clip, collision.contacts[0].point, collision.impulse.magnitude);
	}
}
