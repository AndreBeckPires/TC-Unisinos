using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpawner : MonoBehaviour
{
    public GameObject[] objs;
    public int objectsCount;
    public int points =0;
    // Start is called before the first frame update
    void Start()
    {
        int value = Random.Range(0, 2);
        Debug.Log(value);
        if(value == 0)
        {
            objs[0].SetActive(false);
           objectsCount = objs[1].transform.childCount / 2;
        }
        if(value == 1)
        {
            objs[1].SetActive(false);
            objectsCount = objs[0].transform.childCount / 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(objectsCount <= 0)
        {
            if(objs[1].activeSelf)
            {
                objs[0].SetActive(true);
                objs[1].SetActive(false);
                objectsCount = objs[0].transform.childCount / 2;
                points++;
            }
            else if(objs[0].activeSelf)
            {
                objs[0].SetActive(false);
                objs[1].SetActive(true);
                objectsCount = objs[1].transform.childCount / 2;
                Debug.Log("entrou");
                points++;
            }
            
        }
        if(points >= 2)
        {
            objs[0].SetActive(false);
            objs[1].SetActive(false);
            Debug.Log("cabou");
        }
        
    }
    public void changeCount(int value){
        objectsCount -= value;
        Debug.Log(objectsCount);

    }
}
