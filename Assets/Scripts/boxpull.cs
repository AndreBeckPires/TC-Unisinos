using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxpull : MonoBehaviour
{
    public bool beingPushed;
    float xPos,yPos;
    public GameObject goal;
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
        if(this.transform.position.x - goal.transform.position.x < 0.05f && this.transform.position.y - goal.transform.position.y < 0.05f)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            this.GetComponent<FixedJoint2D>().enabled = false;
           this.gameObject.tag = "T1";
           this.transform.position = goal.transform.position;
            Destroy(goal);
           Debug.Log("nolugar");
         }
    }
}
