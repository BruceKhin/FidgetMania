using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallFidgetSpin : MonoBehaviour {
	public float speed;
	private RectTransform fidgetTransform;
	// Use this for initialization
	void Start () {
		fidgetTransform = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
		fidgetTransform.Rotate(Vector3.forward,45 * speed *Time.deltaTime);
	}
}
