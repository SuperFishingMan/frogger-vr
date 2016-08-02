using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour {

	public float autoLoadTimer = 4f;

	void Start () {
		if (autoLoadTimer > 0) {
			Invoke("LoadNextLevel", autoLoadTimer);
		}
	}
	
	public void LoadNextLevel() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadPreviousLevel() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

	public void ReloadCurrentScene() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
