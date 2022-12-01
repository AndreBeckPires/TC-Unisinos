using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnercolorchanger : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject t1,t2,tb1,tb2,t3,tb3;
    SpriteRenderer sprite;
    int rand;
    bool isActive = false;
    private  Color[] colors = {new Color(1,0,0,1), new Color(0,1,0,1), new Color(0,0,1,1)};
    // Start is called before the first frame update
    void Start()
    {   
        isActive = false;
         t1.SetActive(false);
         tb1.SetActive(false);
         t3.SetActive(false);
         tb3.SetActive(false);
         t2.SetActive(false);
         tb2.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start(){
        for(int i = 0; i < objects.Length; i++)
            {
                sprite = objects[i].GetComponent<SpriteRenderer>();
                sprite.color = colors[Random.Range(0, 3)];
            }
            rand = Random.Range(0,12);
            if(rand == 0 || rand == 2 || rand == 5 || rand == 8 || rand == 11)
            {
                Debug.Log("entrou");
                t1.SetActive(false);
                tb1.SetActive(false);
                t3.SetActive(false);
                tb3.SetActive(false);
                t2.SetActive(true);
                tb2.SetActive(true);
            }
            else if(rand == 1 || rand == 3 || rand == 6 || rand == 9 || rand == 12){
                Debug.Log("entrou");
                t2.SetActive(false);
                tb2.SetActive(false);
                t1.SetActive(false);
                tb1.SetActive(false);
                t3.SetActive(true);
                tb3.SetActive(true);
            }
            else if(rand == 4 || rand == 7 || rand == 10 || rand == 12){
                Debug.Log("entrou");
                t3.SetActive(false);
                tb3.SetActive(false);
                t2.SetActive(false);
                tb2.SetActive(false);
                t1.SetActive(true);
                tb1.SetActive(true);
            }
    }
}
