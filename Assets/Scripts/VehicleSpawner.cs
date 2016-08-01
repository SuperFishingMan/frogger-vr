using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

	public Vehicle[] vehiclePrefabs;
	public float startPosition = -10f;
	public float laneSpeed = 5f;
	
	void Start() {
		SpawnVehicle();
	}

	void SpawnVehicle() {
		Vehicle newVehicle = Instantiate(vehiclePrefabs[0]);
		newVehicle.transform.position = GetPositionOffest();
		newVehicle.transform.parent = transform;
		newVehicle.SetSpeed(laneSpeed);
	}

	Vector3 GetPositionOffest() {
		float spawnHeight = (transform.localScale.y / 2) + (vehiclePrefabs[0].transform.localScale.y / 2);
		return new Vector3(startPosition, spawnHeight, transform.position.z);
	}
}
