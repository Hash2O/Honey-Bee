using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _treePrefabs;
    [SerializeField] private GameObject[] _flowerPrefabs;
    [SerializeField] private GameObject[] _flowerAreaPrefabs;
    [SerializeField] private GameObject[] _bushPrefabs;
    [SerializeField] private GameObject[] _rockPrefabs;

    float spawnRangeX = 9.5f;
    float spawnRangeY = 0;
    float spawnRangeZ = 9.5f;
    float flowerAreaRangeModif = 2.0f;  //Solution type scotch. Génère son lot d'erreurs également

    // Start is called before the first frame update
    void Start()
    {
        //SpawnRandomTree();
        //SpawnRandomFlower();
        //SpawnRandomBush();
        //SpawnRandomRock();
        SpawnRandomFlowerArea();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomTree()
    {
        int randomNumber = Random.Range(0, 11);
        for(int i = 0; i < randomNumber; i++)
        {
            float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
            float spawnPosZ = Random.Range(-spawnRangeZ, spawnRangeZ);
            int objectIndex = Random.Range(0, _treePrefabs.Length);
            Vector3 spawnPosition = new Vector3(spawnPosX, spawnRangeY, spawnPosZ);
            Instantiate(_treePrefabs[objectIndex], spawnPosition,
                _treePrefabs[objectIndex].transform.rotation);
        }
        
    }

    void SpawnRandomFlower()
    {
        int randomNumber = Random.Range(50, 101);
        for (int i = 0; i < randomNumber; i++)
        {
            float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
            float spawnPosZ = Random.Range(-spawnRangeZ, spawnRangeZ);
            int objectIndex = Random.Range(0, _treePrefabs.Length);
            Vector3 spawnPosition = new Vector3(spawnPosX, spawnRangeY, spawnPosZ);
            Instantiate(_flowerPrefabs[objectIndex], spawnPosition,
                _flowerPrefabs[objectIndex].transform.rotation);
        }

    }

    void SpawnRandomFlowerArea()
    {
        int randomNumber = Random.Range(1, 11);
        for (int i = 0; i < randomNumber; i++)
        {
            float spawnPosX = Random.Range(-spawnRangeX + flowerAreaRangeModif, spawnRangeX - flowerAreaRangeModif);
            float spawnPosZ = Random.Range(-spawnRangeZ + flowerAreaRangeModif, spawnRangeZ - flowerAreaRangeModif);
            int objectIndex = Random.Range(0, _treePrefabs.Length);
            Vector3 spawnPosition = new Vector3(spawnPosX, spawnRangeY, spawnPosZ);
            Instantiate(_flowerAreaPrefabs[objectIndex], spawnPosition,
                _flowerAreaPrefabs[objectIndex].transform.rotation);
        }

    }

    void SpawnRandomBush()
    {
        int randomNumber = Random.Range(0, 21);
        for (int i = 0; i < randomNumber; i++)
        {
            float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
            float spawnPosZ = Random.Range(-spawnRangeZ, spawnRangeZ);
            int objectIndex = Random.Range(0, _treePrefabs.Length);
            Vector3 spawnPosition = new Vector3(spawnPosX, spawnRangeY, spawnPosZ);
            Instantiate(_bushPrefabs[objectIndex], spawnPosition,
                _bushPrefabs[objectIndex].transform.rotation);
        }

    }

    void SpawnRandomRock()
    {
        int randomNumber = Random.Range(0, 21);
        for (int i = 0; i < randomNumber; i++)
        {
            float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
            float spawnPosZ = Random.Range(-spawnRangeZ, spawnRangeZ);
            int objectIndex = Random.Range(0, _treePrefabs.Length);
            Vector3 spawnPosition = new Vector3(spawnPosX, spawnRangeY, spawnPosZ);
            Instantiate(_rockPrefabs[objectIndex], spawnPosition,
                _rockPrefabs[objectIndex].transform.rotation);
        }

    }
}
