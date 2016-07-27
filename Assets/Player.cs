using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player: MonoBehaviour {

	public int jumpVelocity = 5;
	public float jumpAngle = 45f;

    private CardboardHead head;
    private Text gazeText;
	private Rigidbody rb;

	private bool onFloor;

	void Start() {
		Cardboard.SDK.OnTrigger += PullTrigger;
        head = GetComponentInChildren<CardboardHead>();
		rb = GetComponent<Rigidbody>();
	}

	void OnCollisionEnter() {
		onFloor = true;
	}

    private void PullTrigger() {
		if (onFloor) {
			onFloor = false;
			Vector3 projectedVector = Vector3.ProjectOnPlane(head.Gaze.direction, Vector3.up);
			Vector3 jumpVector = Vector3.RotateTowards(projectedVector, Vector3.up, jumpAngle * Mathf.Deg2Rad, 0);
			rb.velocity = jumpVector * jumpVelocity;
		}
    }
	
}
