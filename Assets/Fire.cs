using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	private Player player;

	void Start() {
		player = FindObjectOfType<Player>();
	}
	
	void Update() {
		Vector3 delta = player.transform.position - transform.position;
		Vector3 projectedDelta = Vector3.Project(delta, Vector3.left);
		transform.Translate(projectedDelta);
	}
}
