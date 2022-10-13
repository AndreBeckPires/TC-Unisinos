using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsCounter : MonoBehaviour
{

    public Text pointsText;
    int points;
    // Start is called before the first frame update
    void Start()
    {   
        points = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = points.ToString();
    }
    public void setPoints(int i)
    {
        points += i;
    }
}
