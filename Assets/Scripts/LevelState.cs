using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelState : MonoBehaviour {

	private bool _isGameOver = false;
	public bool IsGameOver {
		get { return _isGameOver; }
		set {
			if (value) {
				RecordScore();
			}
			_isGameOver = value;
		}
	}

	private SceneLoader sceneLoader;

	void Start() {
		sceneLoader = FindObjectOfType<SceneLoader>();
	}

	private void RecordScore() {
		GameState gameState = FindObjectOfType<GameState>();
		Player player = FindObjectOfType<Player>();
		gameState.UpdateHighScore(Mathf.FloorToInt(player.transform.position.z));
	}
	
	public void ResetGame() {
		sceneLoader.ReloadCurrentScene();
	} 

	public void BackToMenu() {
		sceneLoader.LoadPreviousLevel();
	}

}
