using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnercolorchanger : MonoBehaviour
{
    public GameObject[] objects;
    SpriteRenderer sprite;
    private  Color[] colors = {new Color(1,0,0,1), new Color(0,1,0,1), new Color(0,0,1,1)};
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < objects.Length; i++)
        {
            sprite = objects[i].GetComponent<SpriteRenderer>();
            sprite.color = colors[Random.Range(0, 3)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
