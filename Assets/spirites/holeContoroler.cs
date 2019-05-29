using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holeContoroler : MonoBehaviour {
	static int joon=4;
	public GameObject first;
	public GameObject second;
	public GameObject third;
	public GameObject fourth;
	public GameObject lole;
	public GameObject ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag.Equals ("Player")) {
			print ("salam");
			if (joon == 4) {
				first.GetComponent<SpriteRenderer> ().color = Color.gray;
			}
			if (joon == 3) {
				second.GetComponent<SpriteRenderer> ().color = Color.gray;
			}
			if (joon == 2) {
				third.GetComponent<SpriteRenderer> ().color = Color.gray;
			}
			if (joon == 1) {
				fourth.GetComponent<SpriteRenderer> ().color = Color.gray;
			}
			joon--;
			systemComeBack ();
		}
	}
	public void systemComeBack(){
		lole.GetComponent<Transform> ().position = new Vector3 (lole.GetComponent<Transform> ().position.x, -5.75f, lole.GetComponent<Transform> ().position.z);
		ball.GetComponent<Transform> ().position = new Vector3 (0.34f, -4.78f, ball.GetComponent<Transform> ().position.z);
		lole.GetComponent<Transform> ().rotation = Quaternion.Euler(0, 0, 0);  ;
	}
}
