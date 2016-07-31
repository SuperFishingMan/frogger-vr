using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameState : MonoBehaviour {

	public bool IsGameOver {
		get; set;
	}

	public void ResetGame() {
		SceneManager.LoadScene("Main");
	} 

	public void BackToMenu() {
		SceneManager.LoadScene("SplashScreen");
	}

}
