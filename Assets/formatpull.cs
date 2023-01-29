using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formatpull : MonoBehaviour
{
    // Start is called before the first frame update
   public bool beingPushed;
    float xPos,yPos;
   // public GameObject goal;
    Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
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
            yPos = transform.position.y;
        }
}
}