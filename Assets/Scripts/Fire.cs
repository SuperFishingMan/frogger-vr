using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public float fireSpeed;

	private Player player;
	private LevelState gameState;

	void Start() {
		player = FindObjectOfType<Player>();
		gameState = FindObjectOfType<LevelState>();
	}
	
	void Update() {
		if (!gameState.IsGameOver) {
			AlignWithPlayer();
			MoveForward();
			CheckIfPlayerBurnt();
		}
	}

	void AlignWithPlayer() {
		Vector3 delta = player.transform.position - transform.position;
		Vector3 projectedDelta = Vector3.Project(delta, Vector3.left);
		transform.Translate(projectedDelta);
	}

	void MoveForward() {
		transform.Translate(Vector3.forward * fireSpeed * Time.deltaTime);
	}

	void CheckIfPlayerBurnt() {
		if (player.transform.position.z < transform.position.z ) {
			gameState.IsGameOver = true;
		}
	}
}
