using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsToWin : MonoBehaviour
{
    private int pointsToWinGame;
    private int currentPoints;
    public GameObject[] items;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        pointsToWinGame = items.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentPoints >= pointsToWinGame){
            //win
            youWin();
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
    public void youWin(){
        canvas.SetActive(true);
    }
}
