using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D playerRb;
    public Animator animator;
    Vector2 movment;

  
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
       movment.x = Input.GetAxisRaw("Horizontal");
       movment.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horizontal", movment.x);
        animator.SetFloat("vertical", movment.y);
        animator.SetFloat("velocity", movment.sqrMagnitude);

        if(movment != Vector2.zero)
        {
             animator.SetFloat("horizontalidle", movment.x);
            animator.SetFloat("verticalidle", movment.y);
        }
        if(movment.x < 0)
        {
            this.gameObject.transform.localScale = new Vector3(1,1,1);
        }


        if(movment.x > 0)
        {
            this.gameObject.transform.localScale = new Vector3(-1,1,1);
        }
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + movment * speed * Time.fixedDeltaTime);
    }
}