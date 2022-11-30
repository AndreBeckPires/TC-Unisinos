using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pointsToWin : MonoBehaviour
{
    private int pointsToWinGame;
    private int currentPoints;
    public GameObject[] items;
    public GameObject canvas, loose;
    public GameObject t1,t2,tb1,tb2;
    public int winsCounter = 0;
    public float timer = 8;

    // Start is called before the first frame update
    void Start()
    {
        pointsToWinGame = items.Length;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            youLoose();
        }
        if(winsCounter >= 2)
        {
            youLoose();
        }
        if(currentPoints >= pointsToWinGame){
            //win
           // youWin();
           currentPoints = 0;
           winsCounter++;
           if(t1.activeSelf)
           {
            t1.SetActive(false);
            tb1.SetActive(false);
            t2.SetActive(true);
            tb2.SetActive(true);
           }
           else{
            t2.SetActive(false);
            tb2.SetActive(false);
            t1.SetActive(true);
            tb1.SetActive(true);
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
    }
    public void restart(){
        SceneManager.LoadScene("SampleScene");
    }
}
