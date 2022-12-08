
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScriptRight : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public bool show;
    public bool shouldRotate = true;
    public AudioSource audio;
    public bool tocou = false, tocou2 = false;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if(shouldRotate)
        {
            if(show)
            {
                if(rigidBody2D.rotation < 0f)
                {
                    if(!tocou)
                    {
                        audio.Play(0);
                        tocou = true;
                    }
                    
                    rigidBody2D.rotation += 1.0f;
                }
        }
       
            if(!show)
            {
            
                if(rigidBody2D.rotation > -90.0f)
                {
                   if(!tocou2)
                    {
                        audio.Play(0);
                        tocou2 = true;
                    }
                    rigidBody2D.rotation -= 1.0f;
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
        tocou = false;
        tocou2 = false;
    }
}
