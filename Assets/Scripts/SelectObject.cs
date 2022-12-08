
using System.Net;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    public GameObject pointsCounter;
    public GameObject[] goals;
    public GameObject lever;
    public GameObject resultSelector;
    bool selected = false;
    float defaultRotation;
    Vector3[] pos;
    float[] rotations;
   public GameObject toDestroy;
   public bool destroy;
    void Update()
    {
        // Call every frame
        MouseInput();
    }
    void Start(){
        destroy = false;
        defaultRotation = lever.GetComponent<Rigidbody2D>().rotation;
        pos[0] = goals[0].transform.position;
        rotations[0] = goals[0].GetComponent<Rigidbody2D>().rotation;

        pos[1] = goals[1].transform.position;
        rotations[1] = goals[1].GetComponent<Rigidbody2D>().rotation;

    }
    void MouseInput()
    {
        // When Mouse 0 is pressed
        if (Input.GetMouseButton(0))
        {
            // Raycast from camera to mouse position
            Vector2 raycastPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(raycastPos, Vector2.zero);

            // If a collider is hit
            if (hit.collider != null)
            {
                // Log the name of the hit object
                if(goals[0].name == "correct")
                {
                    lever.GetComponent<Rigidbody2D>().rotation = defaultRotation;
                    goals[0].GetComponent<rotationScript>().setShouldRotate(false);
                  
                    
                    if(hit.collider.gameObject.name == "correct")
                        {
                            
                            hit.collider.gameObject.GetComponent<Rigidbody2D>().rotation = 90.0f;
                           // Destroy(hit.collider.gameObject);
                            pointsCounter.GetComponent<pointsCounter>().setPoints(1);
                            goals[1].GetComponent<rotationScriptRight>().hideRotate();
                            selected = false;
                            Debug.Log("1");
                        }
                    else if(hit.collider.gameObject.name == "incorrect"){
                        
                            goals[1].GetComponent<rotationScriptRight>().setShouldRotate(false);
                            goals[0].GetComponent<rotationScript>().setShouldRotate(true);
                            hit.collider.gameObject.GetComponent<Rigidbody2D>().rotation = -90.0f;
                           // Destroy(hit.collider.gameObject);
                            pointsCounter.GetComponent<pointsCounter>().fim = true;
                            goals[0].GetComponent<rotationScript>().hideRotate();
                            selected = false;
                            Debug.Log("2");
                        }
                }

                else if(goals[1].name == "correct")
                {
                    lever.GetComponent<Rigidbody2D>().rotation = defaultRotation;
                
                   goals[1].GetComponent<rotationScriptRight>().setShouldRotate(false);
                    
                    if(hit.collider.gameObject.name == "correct")
                        {   
                           
                            hit.collider.gameObject.GetComponent<Rigidbody2D>().rotation = -90.0f;
                            //Destroy(hit.collider.gameObject);                          
                            pointsCounter.GetComponent<pointsCounter>().setPoints(1);
                            goals[0].GetComponent<rotationScript>().hideRotate();
                             selected = false;
                             Debug.Log("3");
                        }
                    else if(hit.collider.gameObject.name == "incorrect"){
                            goals[0].GetComponent<rotationScript>().setShouldRotate(false);
                             goals[1].GetComponent<rotationScriptRight>().setShouldRotate(true);
                            hit.collider.gameObject.GetComponent<Rigidbody2D>().rotation = 90.0f;
                           // Destroy(hit.collider.gameObject);
                            pointsCounter.GetComponent<pointsCounter>().fim = true;
                            goals[1].GetComponent<rotationScriptRight>().hideRotate();
                             selected = false; 
                             Debug.Log("4");
                        }
                }
              
                if(hit.collider.gameObject.name == "lever")
                {   
                    if(!selected)
                    {
                         resultSelector.GetComponent<setResults>().selectRight();
                    }
                    Destroy(toDestroy);
                    selected = true;
                    goals[0].GetComponent<rotationScript>().setShouldRotate(true);
                    goals[1].GetComponent<rotationScriptRight>().setShouldRotate(true);
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().rotation = 28.305f;
                    goals[0].GetComponent<rotationScript>().showRotate();
                    goals[1].GetComponent<rotationScriptRight>().showRotate();
                }
                
                //Destroy(hit.collider.gameObject);
            }
        }
    }

    public void changeObj(string name)
    {
        toDestroy =  GameObject.Find(name);
        destroy = true;
    }
}