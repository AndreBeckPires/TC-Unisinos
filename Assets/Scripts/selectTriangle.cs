
using Microsoft.VisualBasic;
using System.Data.SqlTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectTriangle : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] newSprite;
    int t1 = 0;
    int t2 = 0;
    bool st1 = false;
    bool st2 = false;
    bool first = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseInput();
        if(t1 == 3)
        {
            Debug.Log("win");
        }
        
        if(t2 == 3)
        {
            Debug.Log("win");
        }
    }

    void MouseInput()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 raycastPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(raycastPos, Vector2.zero);

            if(hit.collider != null)
            {
               
                if(first)
                {
                     
                    if(hit.collider.tag == "T1")
                    {
                        st1 = true;
                        st2 = false;
                        t1++;
                        first = false;
                        Debug.Log("entrou");
                    }
                    if(hit.collider.tag == "T2")
                    {
                        st2 = true;
                        st1 = false;
                        t2++;
                        first = false;
                        Debug.Log("entrou");
                    }
                }
                else{
                    if(st1)
                    {
                        if(hit.collider.tag == "T1")
                        {
                            Debug.Log("1++");
                            t1++;
                        }
                        if(hit.collider.tag == "T2")
                        {
                            t1 = 0;
                            first = true;
                        }
                    }
                    if(st2)
                    {
                        if(hit.collider.tag == "T2")
                        {
                            t2++;
                            Debug.Log("2++");
                        }
                        if(hit.collider.tag == "T1")
                        {
                            t2 = 0;
                            first = true;
                        }
                    }
                    
                   

                }
                //Debug.Log(hit.collider.gameObject.tag);
                spriteRenderer = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = newSprite[0];
                
            }
        }
        
    }
}
