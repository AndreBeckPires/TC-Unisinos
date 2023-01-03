using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPush : MonoBehaviour
{
    public float distance = 1.0f;
    public LayerMask boxMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.queriesStartInColliders = false;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left*transform.localScale.x,distance, boxMask);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position+ Vector2.left*transform.localScale.x * distance);
    }
}
