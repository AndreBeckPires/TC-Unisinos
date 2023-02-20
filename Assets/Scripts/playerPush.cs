using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPush : MonoBehaviour
{
    public float distance = 1.0f;
    public LayerMask boxMask;
    public GameObject box;
    public GameObject displayer;
    public GameObject[] box_goals;
    public GameObject[] doors;
    public GameObject door;
     public float timeRemaining = 10.0f;
    public bool abrindo = false;
    public bool fechando = false;
    public int controlador = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.queriesStartInColliders = false;
		RaycastHit2D hit= Physics2D.Raycast (transform.position, Vector2.left * transform.localScale.x, distance, boxMask);

        if (hit.collider != null && hit.collider.gameObject.tag == "pushable" && Input.GetKeyDown(KeyCode.E)) {
                box = hit.collider.gameObject;
                Debug.Log("entrou");
                box.GetComponent<FixedJoint2D>().enabled = true;
                box.GetComponent<boxpull>().beingPushed = true;
                 box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D> ();
        }else if(hit.collider != null && hit.collider.gameObject.tag == "pushable" && Input.GetKeyUp(KeyCode.E))
        {
            box.GetComponent<FixedJoint2D>().enabled = false;
            box.GetComponent<boxpull>().beingPushed = false;

        }
          if (timeRemaining > 0 && abrindo == true)
        {
            timeRemaining -= Time.deltaTime;
        }
        if(timeRemaining > 0 && abrindo)
        {
            fechando = false;
            doors[0].GetComponent<Rigidbody2D>().MovePosition(doors[0].GetComponent<Rigidbody2D>().position + new Vector2(2.0f, 0f) * Time.fixedDeltaTime);
            doors[1].GetComponent<Rigidbody2D>().MovePosition(doors[1].GetComponent<Rigidbody2D>().position + new Vector2(2.0f, 0f) * Time.fixedDeltaTime);
        }
        else if(timeRemaining <= 0 && abrindo){
            abrindo = false;
            timeRemaining = 1.0f;
            controlador++;
            
        }

        if(timeRemaining > 0 && fechando)
        {
            timeRemaining -= Time.deltaTime;
            doors[0].GetComponent<Rigidbody2D>().MovePosition(doors[0].GetComponent<Rigidbody2D>().position + new Vector2(-2.0f, 0f) * Time.fixedDeltaTime);
            doors[1].GetComponent<Rigidbody2D>().MovePosition(doors[1].GetComponent<Rigidbody2D>().position + new Vector2(-2.0f, 0f) * Time.fixedDeltaTime);
        }
        else if(timeRemaining <= 0 && fechando){
            fechando = false;
            timeRemaining = 1.0f;
            controlador++;
            
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "lever")
        {
            Debug.Log("Colidiu");
            collision.gameObject.GetComponent<Rigidbody2D>().rotation = 28.305f;
             displayer.GetComponent<spawnStrings>().display();
               displayer.GetComponent<spawnStrings>().Shuffle();

        if(controlador%2 == 0 )
        {
           
            abrindo = true;
            fechando = false;
            box_goals[0].GetComponent<Collider2D>().enabled = false; 
           box_goals[1].GetComponent<Collider2D>().enabled = false; 
        }
        else{
           
            box_goals[0].GetComponent<Collider2D>().enabled = true; 
           box_goals[1].GetComponent<Collider2D>().enabled = true; 
          abrindo = false;
          fechando = true;
        }
           
       

           
          
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position+ Vector2.left*transform.localScale.x * distance);
       
    }
}