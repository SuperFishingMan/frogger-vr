using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameLoader : MonoBehaviour {

	public void LoadGame() {
		SceneManager.LoadScene("Main");
	}
}
