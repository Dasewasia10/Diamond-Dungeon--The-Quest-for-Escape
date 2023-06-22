using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    public GameObject[] prefabs; // Array of all available prefab sprites
    public Transform[] waypoints; // Array of all waypoints

    private List<int> usedIndices = new List<int>(); // List to store used prefab indices

    void Start()
    {
        SpawnPrefabsAtWaypoints();
    }

    void SpawnPrefabsAtWaypoints()
    {
        int totalWaypoints = waypoints.Length;
        int totalPrefabs = prefabs.Length;

        // Iterate through each waypoint and assign a random prefab
        for (int i = 0; i < totalWaypoints; i++)
        {
            int randomIndex = GetUniqueRandomIndex(totalPrefabs);
            GameObject prefab = prefabs[randomIndex];

            // Instantiate the prefab at the current waypoint position
            Instantiate(prefab, waypoints[i].position, Quaternion.identity);
        }
    }

    int GetUniqueRandomIndex(int maxIndex)
    {
        int randomIndex = Random.Range(0, maxIndex);

        // Check if the index has been used before, if so, generate a new one
        while (usedIndices.Contains(randomIndex))
        {
            randomIndex = Random.Range(0, maxIndex);
        }

        usedIndices.Add(randomIndex);

        return randomIndex;
    }
}
