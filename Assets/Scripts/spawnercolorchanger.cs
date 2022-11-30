using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnercolorchanger : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject t1,t2,tb1,tb2;
    SpriteRenderer sprite;
    int rand;
    private  Color[] colors = {new Color(1,0,0,1), new Color(0,1,0,1), new Color(0,0,1,1)};
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < objects.Length; i++)
        {
            sprite = objects[i].GetComponent<SpriteRenderer>();
            sprite.color = colors[Random.Range(0, 3)];
        }
        rand = Random.Range(0,100);
        if(rand%2 == 0)
        {
            Debug.Log("entrou");
            t1.SetActive(false);
            tb1.SetActive(false);
        }
        else{
            Debug.Log("entrou");
            t2.SetActive(false);
            tb2.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
