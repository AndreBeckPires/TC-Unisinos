
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public GameObject[] squares;
    private Renderer rend;

    private Color nColor;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < squares.Length; i++)
        {
            nColor = new  Color(Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),1.0f);
            squares[i].GetComponent<Renderer>().material.color = nColor;
        }
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
