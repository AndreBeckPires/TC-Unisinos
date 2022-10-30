
using System.Net;
using Microsoft.VisualBasic;
using System.Data.SqlTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectTriangle : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] newSprite;
    public Sprite[] oSprite;
    public GameObject[] objetos;
    public int t1 = 0;
    public int t2 = 0;
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
        if (Input.GetMouseButtonDown(0))
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
                    }
                    if(hit.collider.tag == "T2")
                    {
                        st2 = true;
                        st1 = false;
                        t2++;
                        first = false;
                       
                    }
                }
                else{
                    if(st1)
                    {
                        if(hit.collider.tag == "T1")
                        {
                            
                            t1++;
                        }
                        if(hit.collider.tag == "T2")
                        {
                            t1 = 0;
                            t2++;
                            first = true;
                            error();
                        }
                    }
                    if(st2)
                    {
                        if(hit.collider.tag == "T2")
                        {
                            t2++;
                           
                        }
                        if(hit.collider.tag == "T1")
                        {
                            t2 = 0;
                            t1++;
                            first = true;
                            error();
                        }
                    }
                    
                   

                }
                //Debug.Log(hit.collider.gameObject.tag);
                spriteRenderer = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                for(int i = 0; i < newSprite.Length; i++)
                {
                    if(newSprite[i].name == hit.collider.gameObject.name + "hl")
                    spriteRenderer.sprite = newSprite[i];
                }
                //spriteRenderer.sprite = newSprite[0];
                
            }
        }
    }
    void error()
    {
        for(int i =0; i < objetos.Length; i++)
        {
            for(int j =0; j < oSprite.Length; j++)
            {
                if(objetos[i].name == oSprite[j].name)
                objetos[i].GetComponent<SpriteRenderer>().sprite = oSprite[j];
            }
        }
    }
}
