using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverMessage : MonoBehaviour {

	public float messageDistance = 20f;
	public float messageYPosition = 10f;

	private Canvas canvas;
	private Player player;
	private LevelState gameState;

	private CanvasScaler canvasScaler;
	
	void Start() {
		gameState = FindObjectOfType<LevelState>();
		player = FindObjectOfType<Player>();
		canvas = GetComponent<Canvas>();
		canvasScaler = GetComponent<CanvasScaler>();
		canvas.enabled = false;
		canvasScaler.enabled = false;
	}

	void Update() {
		if (gameState.IsGameOver == true) {
			canvas.enabled = true;
			canvasScaler.enabled = true;
		}
	}
	
	void LateUpdate() {
		transform.rotation = Quaternion.LookRotation(player.LookDirection());
		Vector3 messageOffset = player.LookDirection() * messageDistance;
		transform.position = player.transform.position + messageOffset + Vector3.up * messageYPosition;
	}
}
