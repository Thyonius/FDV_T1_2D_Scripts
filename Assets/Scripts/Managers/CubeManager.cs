using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject cube;
    public Transform[] spawnPoints;
    public int spawnTime = 5;

    private void Start()
    {
        InvokeRepeating("Spawn", 1, spawnTime);
    }

    void Spawn ()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(cube, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

}
