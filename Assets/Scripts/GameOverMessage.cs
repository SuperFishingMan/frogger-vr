using UnityEngine;
using System.Collections;

public class GameOverMessage : MonoBehaviour {

	public float messageDistance = 20f;
	public float messageYPosition = 10f;

	private Player player;
	
	void Start() {
		player = FindObjectOfType<Player>();
	}
	
	void LateUpdate() {
		transform.rotation = Quaternion.LookRotation(player.LookDirection());
		Vector3 messageOffset = player.LookDirection() * messageDistance;
		transform.position = player.transform.position + messageOffset + Vector3.up * messageYPosition;
	}
}
