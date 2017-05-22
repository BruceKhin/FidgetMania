using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashTimer : MonoBehaviour {
	private float time = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if(time<=0){
			SceneManager.LoadScene("MainMenu");
		}
	}
}
