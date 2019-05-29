using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class winContoroller : MonoBehaviour {
	public static int count=0;
	int step1=3;
	int step2=3;
	int step3=3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag.Equals ("Player")) {
			Destroy (GetComponent<SpriteRenderer>());
			Destroy (GetComponent<CircleCollider2D>());
			count++;
			if (count%3 == 0) {
				if (count == 3) {
					SceneManager.LoadScene ("chall2");
				}
				if (count == 6) {
					SceneManager.LoadScene("3");
				}
				
			}
			}
	}
}
