using UnityEngine;
using System.Collections;

public class Vehicle : MonoBehaviour {

	private float speed;
	
	void Update () {
		transform.position += Vector3.right * speed * Time.deltaTime;
	}

	public void SetSpeed(float newSpeed) {
		speed = newSpeed;
	}
}
