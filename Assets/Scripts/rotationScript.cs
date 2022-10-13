
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidBody2D;
    public bool show;
    public bool shouldRotate = true;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        
       
    }

    void FixedUpdate()
    {
        if(shouldRotate)
        {
            if(show)
            {
                if( rigidBody2D.rotation > 0.5f && rigidBody2D.rotation > -1.0f)
                {
                    rigidBody2D.rotation -= 1.0f;
                }
            }
            if(!show)
            {
                if(rigidBody2D.rotation < 90.0f)
                { 
                rigidBody2D.rotation += 1.0f;
                }
            }
        }
        
    }

    public void showRotate(){
        show = true;
    }
    public void hideRotate(){
      show = false;
    }
    public void setShouldRotate(bool set){
        shouldRotate = set;
    }
}
