using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour {

	Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		Debug.Log("hitted" + col.gameObject.name);
		if(col.gameObject.name == "Spring") {

		} else {
		rb2d.AddForce(Vector3.up * 500);
		}
	}
}
