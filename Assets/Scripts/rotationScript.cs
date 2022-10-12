using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidBody2D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
       
    }

    void FixedUpdate()
    {
        if( rigidBody2D.rotation > 0.5f && rigidBody2D.rotation > -1.0f)
        rigidBody2D.rotation -= 1.0f;
    }
}
