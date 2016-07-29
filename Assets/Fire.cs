using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public float fireSpeed;

	private Player player;

	void Start() {
		player = FindObjectOfType<Player>();
	}
	
	void Update() {
		AlignWithPlayer();
		MoveForward();
	}

	void AlignWithPlayer() {
		Vector3 delta = player.transform.position - transform.position;
		Vector3 projectedDelta = Vector3.Project(delta, Vector3.left);
		transform.Translate(projectedDelta);
	}

	void MoveForward() {
		transform.Translate(Vector3.forward * fireSpeed * Time.deltaTime);
	}
}
