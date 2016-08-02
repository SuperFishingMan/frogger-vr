using UnityEngine;
using System.Collections;

public class LethalCollider : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.GetComponent<Player>() != null) {
			LevelState gameState = FindObjectOfType<LevelState>();
			gameState.IsGameOver = true;
		}
	}

}
