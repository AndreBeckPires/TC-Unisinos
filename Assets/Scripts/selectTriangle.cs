
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
    public bool neutro = false;
    public List<GameObject> objToDestroy = new List<GameObject>();
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
            for(int i = 0; i < objToDestroy.Count; i++)
            {
                 Instantiate(explosion, objToDestroy[i].transform.position, Quaternion.identity);
                  Destroy(objToDestroy[i]);
            }
            objToDestroy.Clear();
            st1 = false;
            first = true;
            neutro = false;
         //   Instantiate(explosion, objetos[0].transform.position, Quaternion.identity);
         //   Destroy(objetos[0]);
          //  Instantiate(explosion, objetos[1].transform.position, Quaternion.identity);
           // Destroy(objetos[1]);
           // Instantiate(explosion, objetos[2].transform.position, Quaternion.identity);
           // Destroy(objetos[2]);
        }
        
        if(t2 == 3)
        {   
            t2 =0;
            points++;
            txt.text = points.ToString();
            for(int i = 0; i < objToDestroy.Count; i++)
            {
                 Instantiate(explosion, objToDestroy[i].transform.position, Quaternion.identity);
                  Destroy(objToDestroy[i]);
            }
             objToDestroy.Clear();
            st2 = false;
            first = true;
            neutro = false;
            
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
                        Debug.Log("1");
                    }
                    if(t1 != 0 )
                    {
                         if(hit.collider.tag == "T2")
                        error();
                        Debug.Log("2");
                    }
                    if(hit.collider.tag == "T1")
                    {
                        objToDestroy.Add(hit.collider.gameObject);
                        
                        st1 = true;
                        st2 = false;
                        t1++;
                        first = false;
                        Debug.Log("3");
                      
                    }
                    if(hit.collider.tag == "T2")
                    {
                        st2 = true;
                        st1 = false;
                        t2++;
                        first = false;  
                        Debug.Log("4");     
                        objToDestroy.Add(hit.collider.gameObject);
                    }
                    if(hit.collider.name == "5x5")
                    {
                        first = false;
                        neutro = true;
                        Debug.Log("5");
                        objToDestroy.Add(hit.collider.gameObject);
                    }
                }
                else{
                  
                    if(st1 == false && st2 == false)
                    {
                         if(hit.collider.tag == "T1")
                         {
                            st1 = true;
                            t1 += 2;
                            Debug.Log("6");
                            objToDestroy.Add(hit.collider.gameObject);
                         }
                        
                          if(hit.collider.tag == "T2")
                          {
                             st2 = true;
                             t2 += 2;
                             Debug.Log("7");
                             objToDestroy.Add(hit.collider.gameObject);
                          }
                          if( hit.collider.name == "5x5")
                          {
                            error();
                            Debug.Log("12");  
                           
                            st2 = false;
                            st1 = false;
                            t1 = 0;
                            t2 = 0;  
                          }                          
                    }
                   else if(st1)
                    {
                        if(hit.collider.tag == "T1")
                        {
                            objToDestroy.Add(hit.collider.gameObject);
                            st1 = true;
                            st2= false;
                            t1++;
                         Debug.Log("8");

                        }
                        if(hit.collider.tag == "T2" &&  hit.collider.name != "5x5")
                        {
                            t1 = 0;
                            t2++;
                           st1 = false;
                           st2 = true;
                        neutro = false;
                            error();
                             objToDestroy.Add(hit.collider.gameObject);
                            Debug.Log("9");
                            
                        }
                        if(hit.collider.name == "5x5")
                        {
                            if(neutro)
                            {
                                error();

                                st1 = false;
                                st2 = false;
                                t1 = 0;
                                t2 =0;
                            }
                            else{
                            st1 = true;
                            st2= false;
                            t1++;
                             objToDestroy.Add(hit.collider.gameObject);
                            }
                           
                         Debug.Log("13");
                        }
                        
                    }
                  else  if(st2)
                    {
                  

                        if(hit.collider.tag == "T2") 
                        {   
                            st1 = false;
                            st2 = true;
                            t2++;
                        Debug.Log("10");
                        objToDestroy.Add(hit.collider.gameObject);
                           
                        }
                        if(hit.collider.tag == "T1"  &&  hit.collider.name != "5x5")
                        {
                            //  st1 = true;
                          //  st2 = false;
                            t2 = 0;
                            t1++;
                            neutro = false;
                            st2 = false;
                            st1 = true;
                            Debug.Log("11");
                            error();
                              objToDestroy.Add(hit.collider.gameObject);
                        }
                         if(hit.collider.name == "5x5")
                        {
                              if(neutro)
                            {
                                error();
                                st1 = false;
                                st2 = false;
                                t1 = 1;
                                t2 =0;
                            }
                            else{
                            st1 = false;
                            st2= true;
                            t2++;
                            objToDestroy.Add(hit.collider.gameObject);
                            }
                            
                         Debug.Log("14");
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
        objToDestroy.Clear();
      // neutro = false;
        for(int i =0; i < objetos.Length; i++)
        {
             spriteRenderer = objetos[i].GetComponent<SpriteRenderer>();
            spriteRenderer.color = colors[1];
            
        }
    }
}
