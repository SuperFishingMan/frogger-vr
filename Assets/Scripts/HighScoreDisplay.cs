using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScoreDisplay : MonoBehaviour {

	private GameState gameState;
	private Text highScoreText;

	void Start() {
		gameState = FindObjectOfType<GameState>();
		highScoreText = GetComponent<Text>();
		highScoreText.text = "Current High Score: " + gameState.GetScore() + " meters";
	}
}
