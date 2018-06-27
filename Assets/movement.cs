using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {


	public float speed;
	public float reverse_speed;
	public float acceleration; // public floats meaning the variables can be changed within unity on the fly
	public float rotation_speed;
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) 
			transform.Translate (speed, 0, 0);
		if (Input.GetKey (KeyCode.S)) 
			transform.Translate (-reverse_speed, 0, 0);
			
		if (Input.GetKey (KeyCode.A))
			transform.Rotate (0, 0, rotation_speed);
		if (Input.GetKey (KeyCode.D))
			transform.Rotate (0, 0, -rotation_speed);
	}
}
	