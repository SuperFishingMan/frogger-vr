using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	private int highScore;

	void Awake() {
		DontDestroyOnLoad(gameObject);
	}
	
	public void UpdateHighScore(int score) {
		if (score > highScore) highScore = score;
	}

	public int GetScore() {
		return highScore;
	}
}
