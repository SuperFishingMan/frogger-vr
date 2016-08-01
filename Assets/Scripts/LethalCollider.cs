using UnityEngine;
using System.Collections;

public class LethalCollider : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.GetComponent<Player>() != null) {
			GameState gameState = FindObjectOfType<GameState>();
			gameState.IsGameOver = true;
		}
	}

}
