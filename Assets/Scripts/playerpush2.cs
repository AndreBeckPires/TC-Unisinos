using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpush2 : MonoBehaviour
{
   public float distance = 1.0f;
    public LayerMask boxMask;
    public GameObject box;
    public GameObject displayer;
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
                box.GetComponent<boxpull2>().beingPushed = true;
                 box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D> ();
        }else if(Input.GetKeyUp(KeyCode.E))
        {
            box.GetComponent<FixedJoint2D>().enabled = false;
            box.GetComponent<boxpull2>().beingPushed = false;

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
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position+ Vector2.left*transform.localScale.x * distance);
       
    }
}
