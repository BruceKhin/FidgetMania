using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FidgetSpinner : MonoBehaviour {
	public float speed;
	public RectTransform fidgetTransform;
	private bool rotate;
	private AudioSource audio;

    float initialSpeed;

	void Start () {
		fidgetTransform = GetComponent<RectTransform>();
		audio = GetComponent<AudioSource>();
        initialSpeed = speed;
    }
	
	void Update () {
		if(rotate){
            fidgetTransform.Rotate(Vector3.forward,45 * speed *Time.deltaTime);
			speed = speed-0.08f;
			if(speed<=0){
				audio.Stop();
				rotate = false;
			}
		}
	}
	public void onClick(){
		rotate = true;
		speed = initialSpeed;
		PlayClip();
	}
	public void PlayClip(){
		audio.Play();	
	}
}
