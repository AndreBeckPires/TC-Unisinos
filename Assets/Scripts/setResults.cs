
using UnityEngine;
using UnityEngine.UI;

public class setResults : MonoBehaviour
{
    public Text[] result;
    int right = 2;
    int wrong;
    public GameObject[] goals;
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectRight(){
        int correctAnswer = Random.Range(0,2);
        do{
            wrong = Random.Range(-10, 10);
        }while(wrong == right);
       
        goals[correctAnswer].name = "correct";
        if(correctAnswer == 1)
        goals[0].name = "incorrect";
        if(correctAnswer == 0)
        goals[1].name = "incorrect";

        result[correctAnswer].text = right.ToString();
        for(int i =0; i <=1; i++)
        {
            if(i != correctAnswer)
            {
                result[i].text = wrong.ToString();
            }
        }
    }
}
