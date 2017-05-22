using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds;
using GoogleMobileAds.Api;
public class SceneController : MonoBehaviour {
	private static SceneController instance;
	private float time;
	void Start(){
		if(instance == null){
			instance = this;
		}else{
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}
	public void changeScene(string scene){
	 GameObject buttonSound= (GameObject) GameObject.Find("ButtonSound");
	 	buttonSound.GetComponent<AudioSource>().Play();
		SceneManager.LoadScene(scene);
		}
}
