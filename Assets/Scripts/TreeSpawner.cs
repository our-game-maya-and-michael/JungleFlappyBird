using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public float spawnInterval = 3f; // Time between each tree spawn
    public float distanceFromCamera = 20f; // Distance ahead of the camera to spawn trees
    public float fixTheTop;
    public float fixTheBottom;
    public GameObject[] treePrefabs; // Array to hold different tree prefabs

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main; // Get the main camera
        StartCoroutine(SpawnTrees());
    }

    IEnumerator SpawnTrees()
    {
        while (true)
        {
            // Randomly select a tree prefab for the top and bottom trees
            GameObject topTreePrefab = treePrefabs[Random.Range(0, treePrefabs.Length)];
            GameObject bottomTreePrefab = treePrefabs[Random.Range(0, treePrefabs.Length)];

            // Calculate spawn position relative to the camera
            float spawnPosX = mainCamera.transform.position.x + distanceFromCamera;
            Vector3 topSpawnPos = new Vector3(spawnPosX, mainCamera.ViewportToWorldPoint(new Vector3(0, 1, mainCamera.nearClipPlane)).y - fixTheTop, 0);
            Vector3 bottomSpawnPos = new Vector3(spawnPosX, mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane)).y + fixTheBottom, 0);

            // Instantiate the trees at the top and bottom positions
            Instantiate(topTreePrefab, topSpawnPos, Quaternion.Euler(0, 0, 180)); // Rotate 180 degrees around the Z-axis
            Instantiate(bottomTreePrefab, bottomSpawnPos, Quaternion.identity);

            // Wait for the specified interval before spawning the next pair of trees
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}