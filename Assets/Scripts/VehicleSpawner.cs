using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

	public Vehicle[] vehiclePrefabs;
	public float startPosition = -10f;
	public float laneSpeed = 5f;
	public float laneLength = 50f;
	public float maxSpawnTime = 10f;
	
	void Start() {
		StartCoroutine("Spawn");
	}

	IEnumerator Spawn() {
		while (true) {
			yield return new WaitForSeconds(Random.Range(0.5f, maxSpawnTime));
			int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);
			SpawnVehicle(vehicleIndex);
		}
	}

	void SpawnVehicle(int vehicleIndex) {
		Vehicle newVehicle = Instantiate(vehiclePrefabs[vehicleIndex]);
		newVehicle.transform.position = GetPositionOffest();
		newVehicle.transform.parent = transform;
		newVehicle.SetPath(laneSpeed, laneLength);
	}

	Vector3 GetPositionOffest() {
		float spawnHeight = (transform.localScale.y / 2) + (vehiclePrefabs[0].transform.localScale.y / 2);
		return new Vector3(startPosition, spawnHeight, transform.position.z);
	}
}
