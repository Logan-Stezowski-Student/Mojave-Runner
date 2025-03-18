using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacleInstances;
    public int numberOfInstances = 10;
    public int instanceIndex = 0;

    public GameObject obstaclePrefab;
    public float timeToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Random.Range(2f, 4f);

        obstacleInstances = new GameObject[numberOfInstances];

        for (int i = 0; i < obstacleInstances.Length; i++) 
        {
            obstacleInstances[i] = Instantiate(obstaclePrefab);
            obstacleInstances[i].transform.position = transform.position;
            obstacleInstances[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;

        if (timeToSpawn <= 0.0f) 
        {
            SpawnObstacle();
            timeToSpawn = Random.Range(2f, 4f);
        }
    }

    void SpawnObstacle() 
    {
        obstacleInstances[instanceIndex].SetActive(true);
        obstacleInstances[instanceIndex].transform.position = transform.position;
        instanceIndex++;
        if (instanceIndex == numberOfInstances) 
        {
            instanceIndex = 0;
        }
    }
}
