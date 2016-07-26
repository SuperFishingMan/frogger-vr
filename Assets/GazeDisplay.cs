using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GazeDisplay : MonoBehaviour {

    private CardboardHead head;
    private Text gazeText;

	void Start() {
        head = FindObjectOfType<CardboardHead>();
        gazeText = GetComponentInChildren<Text>();
	}
	
	void Update() {
        gazeText.text = head.Gaze.ToString();
	}
}
