using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxpull : MonoBehaviour
{
    public bool beingPushed;
    float xPos,yPos;
    // Start is called before the first frame update
    void Start()
    {
        xPos = transform.position.x;   
        yPos = transform.position.y; 
    }

    // Update is called once per frame
    void Update()
    {
        if(beingPushed == false)
        {
            transform.position = new Vector3(xPos, yPos);
        }
        else
        {
            xPos = transform.position.x;
        }
    }
}
