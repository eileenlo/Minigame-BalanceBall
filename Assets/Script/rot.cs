using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour {
	Quaternion r;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up") || Input.GetKey (KeyCode.W)) {
			r = Quaternion.Euler (5, 0, 0);
			transform.rotation = Quaternion.Slerp (transform.rotation,r,Time.deltaTime*1f);
		} else if (Input.GetKey ("down") || Input.GetKey (KeyCode.S)) {
			r = Quaternion.Euler (-5, 0, 0);
			transform.rotation = Quaternion.Slerp (transform.rotation,r,Time.deltaTime*1f);
		} else if (Input.GetKey ("left") || Input.GetKey (KeyCode.A)) {
			r = Quaternion.Euler (0, 0, 5);
			transform.rotation = Quaternion.Slerp (transform.rotation,r,Time.deltaTime*1f);
		} else if (Input.GetKey ("right") || Input.GetKey (KeyCode.D)) {
			r = Quaternion.Euler (0, 0, -5);
			transform.rotation = Quaternion.Slerp (transform.rotation,r,Time.deltaTime*1f);
		}
	}
}
