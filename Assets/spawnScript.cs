
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;
    public GameObject[] prefabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if(Input.GetMouseButtonDown(0))
            {
                int randPrefab = Random.Range(0, prefabs.Length);
                int randSpawnPoint = Random.Range(0, spawnPoints.Length);
                Instantiate(prefabs[randPrefab], spawnPoints[randSpawnPoint].position, Quaternion.identity);
            }



    }
}
