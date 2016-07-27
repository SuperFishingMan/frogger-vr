using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] lanePrefabs;
	public float spawnHorizon = 500f;
	public float laneWidth = 2f;

	private Player player;
	private float nextLaneOffset = 0f;
	
	void Start () {
		player = FindObjectOfType<Player>();
	}
	
	void Update () {
		while (nextLaneOffset < player.transform.position.z + spawnHorizon) {
			SpawnLaneAt(nextLaneOffset);
			nextLaneOffset += laneWidth;
		}
	}

	void SpawnLaneAt(float z) {
		int randomLaneIndex = Random.Range(0, lanePrefabs.Length);
		GameObject newLane = Instantiate(lanePrefabs[randomLaneIndex], Vector3.forward * z, Quaternion.identity) as GameObject;
		newLane.transform.parent = transform;
	}
}
