using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_contoroller : MonoBehaviour {
	public GameObject max;
	Rigidbody2D rb;
	bool wPressed=false;
	bool feleshpresed=false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y > max.GetComponent<Transform> ().position.y) {
		}
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.UpArrow)) {
			rb.angularVelocity = 0;
			rb.velocity = Vector2.up * 2;
		} else if (Input.GetKey (KeyCode.W)) {
			if (Mathf.Abs (transform.rotation.eulerAngles.z) < 10||Mathf.Abs (transform.rotation.eulerAngles.z)>350) {
				rb.angularVelocity = -10;
			} else {
				rb.angularVelocity = 0;
			}
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			if (Mathf.Abs (transform.rotation.eulerAngles.z) < 10||Mathf.Abs (transform.rotation.eulerAngles.z)>350) {
				rb.angularVelocity = 10;
			} else {
				rb.angularVelocity = 0;
			}
		} else if (Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.DownArrow)) {
			rb.velocity = Vector2.up * -2;
		} else if (transform.rotation.z != 0) {
			transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (Vector3.zero), Time.deltaTime);
		}
		if (Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.DownArrow)||Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.UpArrow)) {
			rb.velocity = Vector2.zero;
		}
		if (Input.GetKeyUp (KeyCode.W)||Input.GetKeyUp(KeyCode.UpArrow)) {
			rb.angularVelocity = 0;
		}
			


	}
}
