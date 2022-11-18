
using System.Runtime.InteropServices.ComTypes;
using System.Net;
using Microsoft.VisualBasic;
using System.Data.SqlTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectTriangle : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] newSprite;
    public Sprite[] oSprite;
    public GameObject[] objetos;
    public GameObject explosion;
    public int t1 = 0;
    public int t2 = 0;
    public bool st1 = false;
    public bool st2 = false;
    public bool first = true;
    public Text txt;
    int points = 0;
     private  Color[] colors = {new Color(1,0,0,1), new Color(1,1,1,1)};
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
            t1 =0;
            points++;
            txt.text = points.ToString();
            Instantiate(explosion, objetos[0].transform.position, Quaternion.identity);
            Destroy(objetos[0]);
            Instantiate(explosion, objetos[1].transform.position, Quaternion.identity);
            Destroy(objetos[1]);
            Instantiate(explosion, objetos[2].transform.position, Quaternion.identity);
            Destroy(objetos[2]);
        }
        
        if(t2 == 3)
        {   
            t2 =0;
            points++;
            txt.text = points.ToString();
            Instantiate(explosion, objetos[0].transform.position, Quaternion.identity);
            Destroy(objetos[0]);
            Instantiate(explosion, objetos[1].transform.position, Quaternion.identity);
            Destroy(objetos[1]);
            Instantiate(explosion, objetos[2].transform.position, Quaternion.identity);
            Destroy(objetos[2]);
            
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
                    if(t2 != 0){
                        if(hit.collider.tag == "T1")
                        error();
                    }
                    if(t1 != 0 )
                    {
                         if(hit.collider.tag == "T2")
                        error();
                    }
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
                           // st1 = false;
                          //  st2 = true;
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
                             Debug.Log("entrou");
                            //  st1 = true;
                          //  st2 = false;
                            t2 = 0;
                            t1++;
                            first = true;
                            
                            error();
                        }
                    }
                    
                   

                }
                //Debug.Log(hit.collider.gameObject.tag);
                spriteRenderer = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                spriteRenderer.color = colors[0];
               // for(int i = 0; i < newSprite.Length; i++)
             //   {
              //      if(newSprite[i].name == hit.collider.gameObject.name + "y")
              //      spriteRenderer.sprite = newSprite[i];
             //       Debug.Log("sp");
//}
                //spriteRenderer.sprite = newSprite[0];
                
            }
        }
    }

    void error()
    {
       
        for(int i =0; i < objetos.Length; i++)
        {
             spriteRenderer = objetos[i].GetComponent<SpriteRenderer>();
            spriteRenderer.color = colors[1];
            
        }
    }
}
