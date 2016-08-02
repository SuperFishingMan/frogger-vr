using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelState : MonoBehaviour {

	private SceneLoader sceneLoader;

	void Start() {
		sceneLoader = FindObjectOfType<SceneLoader>();
	}

	public bool IsGameOver {
		get; set;
	}

	public void ResetGame() {
		sceneLoader.ReloadCurrentScene();
	} 

	public void BackToMenu() {
		sceneLoader.LoadPreviousLevel();
	}

}
