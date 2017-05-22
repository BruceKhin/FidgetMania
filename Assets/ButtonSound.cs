using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour {
	private static ButtonSound instance;
	// Use this for initialization
	public void Start(){
			if(instance==null){
			instance = this;
		}else{
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}
}
