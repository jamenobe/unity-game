using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	public float firerate = 0;
	public float damage = 10;	
	public LayerMask nottohit;
	public Transform BulletTrail; 

	float numb = 0;
	float timetofire = 0;
	Transform ship;
	Transform dir;


	// Use this for initialization
	void Awake () {
		ship = GameObject.Find("ship").GetComponent<Transform>();
		dir = transform.FindChild ("sht");
		if (ship == null) {
			Debug.LogError ("no fire point");
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		if (firerate == 0) {
			if (Input.GetKey (KeyCode.Space)){
				Shoot();

			}
		}

		else {
			if (Input.GetKey (KeyCode.Space)&& Time.time > timetofire){
				timetofire = Time.time + 1/firerate;
				Shoot();
			
			}

		}
	}
	void Shoot () {
		Debug.Log ("test");
		Vector2 shootPosition = new Vector2 (dir.position.x, dir.position.y);
		Vector2 shipPosition = new Vector2 (ship.position.x, ship.position.y);
		Effect ();
		RaycastHit2D hit;
		if (Physics2D.Raycast(shipPosition, shootPosition, Mathf.Infinity, nottohit)){
			//Destroy(hit.transform.gameObject);
			Destroy(GetComponent<RaycastHit2D>().transform.gameObject);
			Debug.DrawRay(shipPosition, shootPosition * 1000, Color.white);
			Debug.Log ("hit");
		}

	}

	void Effect (){

		Instantiate (BulletTrail, ship.position, ship.rotation);
	}

}
