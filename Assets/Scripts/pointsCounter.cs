using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsCounter : MonoBehaviour
{

    public Text pointsText;
    public  int points;
    public bool fim;
    public GameObject endGame;
    public Text endGameText;
    // Start is called before the first frame update
    void Start()
    {   
        points = 0;  
        fim = false;
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = points.ToString();
        if(fim == true || points == 6)
        {
            endGameText.text = "Sua pontuação: " + points.ToString();
            endGame.SetActive(true);
        }
    }
    public void setPoints(int i)
    {
        points += i;
    }
}
