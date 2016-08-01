using UnityEngine;
using System.Collections;

public class Vehicle : MonoBehaviour {

	private float speed;
	private float length;
	
	void Start() {
		float lifetime = length / speed;
		Invoke("Remove", lifetime);
	}

	void Update () {
		transform.position += Vector3.right * speed * Time.deltaTime;
	}

	public void SetPath(float newSpeed, float newLength) {
		speed = newSpeed;
		length = newLength;
	}

	void Remove() {
		Destroy(gameObject);
	}
}
