using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpawner : MonoBehaviour
{
    public GameObject[] objs;
    public int objectsCount;
    public int points =0;
    public GameObject canvas;
    public GameObject block;
    public GameObject door;
    public float timeRemaining = 1.0f;
    public bool finished;
    // Start is called before the first frame update
    void Start()
    {
        finished = false;
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
         if (timeRemaining > 0 && finished == true)
        {
            timeRemaining -= Time.deltaTime;
        }
        if(timeRemaining > 0 && finished)
        {
            block.GetComponent<Rigidbody2D>().MovePosition(block.GetComponent<Rigidbody2D>().position + new Vector2(0, 0.3f) * Time.fixedDeltaTime);
        }
        
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
           // canvas.SetActive(true);
           finished = true;
           door.SetActive(true);

        }
        
    }
    public void changeCount(int value){
        objectsCount -= value;
        Debug.Log(objectsCount);

    }
}
