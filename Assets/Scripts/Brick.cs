using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit; 
	private LevelManager levelManager;

	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void Update () {
	}

	void OnCollisionExit2D (Collision2D col) {
		timesHit++;
		if (timesHit == maxHits) {
			Destroy(gameObject);
		}
	}

}
