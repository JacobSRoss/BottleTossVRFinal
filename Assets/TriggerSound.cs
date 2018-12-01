using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSound : MonoBehaviour {
	public AudioSource hitSound;
    public Text score;
    public int num = 0;

	// Use this for initialization
	void Start () {
		hitSound = GetComponent<AudioSource>();
		print("start");
        score.text = "Score: 0";
	}
	void OnTriggerEnter(Collider other)
	{
		hitSound.Play();
        num++;
        score.text = "Score: " + num;
		print("land played");
	}
	void OnCollisionEnter(Collision collision)
	{
		print("collisionenter");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
