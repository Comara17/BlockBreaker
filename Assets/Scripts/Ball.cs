using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Paddle Paddle;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;

	void Start () {
		paddleToBallVector = this.transform.position - Paddle.transform.position;

	}
	
	void Update () {
		
		if (!hasStarted) {
			this.transform.position = Paddle.transform.position + paddleToBallVector;

			if (Input.GetMouseButtonDown(0)) {
				Debug.Log("Mouse clicked, launch ball");
				hasStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 7f);

			}
		}
	}
}
