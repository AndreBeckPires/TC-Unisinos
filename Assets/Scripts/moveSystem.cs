
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;
    public GameObject correctForm;
    private bool mooving;
    public GameObject handler;
    private float startPosX;
    private float startPosY;
    private bool finished;

    private Vector3 resetPosition;
    void Start()
    {
         audio = GetComponent<AudioSource>();
        resetPosition = this.transform.localPosition;   
    }

    // Update is called once per frame
    void Update()
    {
        if(!finished)
        {
            if(mooving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }
    }
     

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0)){
            Vector3 mousePos;
            mousePos  = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            mooving = true;
        }
    }
    private void OnMouseUp()
    {
        mooving = false;
        
        if(Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.5f)
        {
             audio.Play(0);
            //this.transform.localPosition = new Vector3(correctForm.transform.localPosition.x, correctForm.transform.localPosition.y, correctForm.transform.localPosition.z);
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            finished = true;
            handler.GetComponent<pointsToWin>().AddPoints();


        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x,resetPosition.y,resetPosition.z);
        }
    }
}
