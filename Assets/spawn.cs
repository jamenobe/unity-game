using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public float SpawnRate;
	public Transform asteroid;
	public float SpawnCap;
	double timetospawn;
	public float quantity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		if (quantity < SpawnCap){
			if (Time.time > timetospawn) {
				timetospawn = Time.time + 0.25 / SpawnRate;	
				quantity += 1;
				spawn_asteroid ();
			}
		}

		if (quantity >= SpawnCap) {
		
			destroy();
			quantity = quantity -= 1;
			Debug.Log ("quantity = " + SpawnCap);
		
		}

	}
	void spawn_asteroid() {
		
		Vector2 pos = new Vector2 (Random.Range (50, -50), Random.Range (50, -50));

		Instantiate (asteroid, pos, transform.rotation);


	}

	void destroy() {
	
		Destroy (gameObject);

	
	}

		

}
