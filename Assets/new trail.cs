﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newtrail : MonoBehaviour {

	public int MoveSpeed = 230;

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * MoveSpeed);
	}
}
