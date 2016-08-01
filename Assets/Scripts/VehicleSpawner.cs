using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

	public Vehicle[] vehiclePrefabs;
	public float startPosition = -10f;
	public float laneSpeed = 5f;
	public float laneLength = 50f;
	
	void Start() {
		SpawnVehicle();
	}

	void SpawnVehicle() {
		Vehicle newVehicle = Instantiate(vehiclePrefabs[0]);
		newVehicle.transform.position = GetPositionOffest();
		newVehicle.transform.parent = transform;
		newVehicle.SetPath(laneSpeed, laneLength);
	}

	Vector3 GetPositionOffest() {
		float spawnHeight = (transform.localScale.y / 2) + (vehiclePrefabs[0].transform.localScale.y / 2);
		return new Vector3(startPosition, spawnHeight, transform.position.z);
	}
}
