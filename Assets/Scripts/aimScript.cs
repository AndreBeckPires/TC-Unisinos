using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = (Camera.main.ScreenToWorldPoint(Input.mousePosition));
       transform.position = new Vector2(mousePosition.x, mousePosition.y);
    }
    
    
}