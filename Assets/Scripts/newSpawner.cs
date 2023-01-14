using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpawner : MonoBehaviour
{
    public GameObject[] objs;
    // Start is called before the first frame update
    void Start()
    {
        int value = Random.Range(0, 2);
        Debug.Log(value);
        if(value == 0)
        {
            objs[0].SetActive(false);
        }
        if(value == 1)
        {
            objs[1].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
