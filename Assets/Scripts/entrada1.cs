using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entrada1 : MonoBehaviour
{
   // public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void OnCollisionEnter2D(Collision2D coll)
    {
        // If the Collider2D component is enabled on the collided object
        if (coll.collider == true)
        {
            if(coll.gameObject.tag == "Player")
            // Disables the Collider2D component
            if(this.gameObject.name == "entrada1")
            SceneManager.LoadScene("minigame2");
            if(this.gameObject.name == "entrada2")
            SceneManager.LoadScene("triopitagorico");   
           if(this.gameObject.name == "entrada3")
           SceneManager.LoadScene("SampleScene");   
               

        }
    }
}
