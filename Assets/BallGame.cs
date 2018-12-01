using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGame : MonoBehaviour {

	public GameObject ball;  
	public float startHeight = 10f;  
	public float fireInterval = 5f;
	private float nextBallTime = 0.0f;
	private GameObject activeBall; 
	private Transform head; 
	private AudioSource audio;
    private float rand;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>(); 
		head = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextBallTime) 
		{
            rand = Random.Range(1, 5);
            Vector3 randomSize = new Vector3(rand, rand, rand);
            nextBallTime = Time.time + fireInterval;
            print(nextBallTime);
            print(fireInterval);
            audio.Play(); 
			//instantiate ball 
			Vector3 position = new   Vector3(head.position .x, startHeight, head .position .z+ .4f);   
			activeBall =Instantiate(ball, position, Quaternion.identity) as GameObject;
            activeBall.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            activeBall.transform.localScale = randomSize;

        } 
	}
}
