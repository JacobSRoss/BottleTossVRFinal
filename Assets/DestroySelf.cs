using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroySelf : MonoBehaviour {

    public Text scoreText;
	public int score = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -5) {
			score++;
			scoreText.text = "Score: " + score;
			Destroy(gameObject);
		}
	}
}
