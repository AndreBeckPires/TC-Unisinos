using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pointsToWin : MonoBehaviour
{
    private int pointsToWinGame;
    private int currentPoints;
    public GameObject[] items;
    public GameObject canvas, loose;
    public GameObject t1,t2,tb1,tb2,t3,tb3;
    public int winsCounter = 0;
    public float timer;
    public bool f1 = false,f2 = false,f3 = false;
    public Text timerText;
    public GameObject timerCanvas;
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        pointsToWinGame = items.Length;
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive == true)
        {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("F0");
        if(timer <= 0)
        {
           timerCanvas.SetActive(false);
            youLoose();
        }
        if(winsCounter >= 3)
        {
            youWin();
        }
        if(currentPoints >= pointsToWinGame){
            //win
           // youWin();
          timer = 10;
           currentPoints = 0;
           winsCounter++;
           if(t1.activeSelf)
           {
            f1 = true;
            t1.SetActive(false);
            tb1.SetActive(false);
            if(Random.Range(0,2) == 1 && f2 == false)
            {
                t2.SetActive(true);
                tb2.SetActive(true);
            }
            else{
                t3.SetActive(true);
                tb3.SetActive(true);
            }
          
           }
            else if(t2.activeSelf){
            f2 = true;
            t2.SetActive(false);
            tb2.SetActive(false);
             if(Random.Range(0,2) == 1 && f1 == false)
            {
                t1.SetActive(true);
                tb1.SetActive(true);
            }
            else{
                t3.SetActive(true);
                tb3.SetActive(true);
            }
           }
            else if(t3.activeSelf){
            f3 = true;
            t3.SetActive(false);
            tb3.SetActive(false);
            if(Random.Range(0,2) == 1 && f2 == false)
            {
                t2.SetActive(true);
                tb2.SetActive(true);
            }
            else{
                t1.SetActive(true);
                tb1.SetActive(true);
            }
           }
        }
        }
       
    }

    public void AddPoints()
    {
        currentPoints++;
    }
    public void youWin(){
        canvas.SetActive(true);
    }
    public void youLoose(){
        loose.SetActive(true);
        t1.SetActive(false);
        t2.SetActive(false);
        tb1.SetActive(false);
        tb2.SetActive(false);
        t3.SetActive(false);
        tb3.SetActive(false);;

    }
    public void restart(){
        SceneManager.LoadScene("SampleScene");
    }
    public void setTimer(float newTimer){
        timer = newTimer;
        isActive = true;
    }
}
