using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player: MonoBehaviour {

	public int jumpVelocity = 5;
	public float jumpAngle = 45f;

    private CardboardHead head;
	private Rigidbody rb;

	private float lastJumpRequestTime;

	void Start() {
		Cardboard.SDK.OnTrigger += PullTrigger;
        head = GetComponentInChildren<CardboardHead>();
		rb = GetComponent<Rigidbody>();
	}

    private void PullTrigger() {
		JumpRequested();
    }

	private void JumpRequested() {
		lastJumpRequestTime = Time.time;
		rb.WakeUp();
	}

	private void Jump() {
		Vector3 jumpVector = Vector3.RotateTowards(LookDirection(), Vector3.up, jumpAngle * Mathf.Deg2Rad, 0);
		rb.velocity = jumpVector * jumpVelocity;
	}

	public Vector3 LookDirection() {
		return Vector3.ProjectOnPlane(head.Gaze.direction, Vector3.up);
	}

	void OnCollisionStay(Collision collision) {
		float delta = Time.time - lastJumpRequestTime;
		if (delta < 0.1) {
			Jump();
			lastJumpRequestTime = 0f;
		}
	}

}
