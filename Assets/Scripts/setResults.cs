
using UnityEngine;
using UnityEngine.UI;

public class setResults : MonoBehaviour
{
    public Text[] result;
    int right = 2;
    int wrong;
    public GameObject[] goals;
    public GameObject[] prefabs;
    public string[] names = new string[] {"Losango", "Trapézio", "Triângulo", "Quadrado", "Pentágono", "Hexágono"};
    public int[] index = {0,1,2,3,4,5};
    public int iterator = 0;
    public GameObject aim;
    // Start is called before the first frame update
    void Start()
    {
        Shuffle(index);
   /*     for(int i =0; i < index.Length; i++)
        {
            Debug.Log(index[i]);
        }*/
        //Instantiate(prefabs[index[0]], new Vector3(0,3.7f,0),Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectRight(){
        if(iterator < 6)
        {
            if(iterator != 0)
            {
                aim.GetComponent<SelectObject>().changeObj(names[index[iterator-1]]+"(Clone)");
                Debug.Log(names[index[iterator-1]]+"(Clone)");
            }
            
            spawn();
        int correctAnswer = Random.Range(0,2);
        do{
            wrong = Random.Range(-10, 10);
        }while(wrong == right);
       
        goals[correctAnswer].name = "correct";
        if(correctAnswer == 1)
        goals[0].name = "incorrect";
        if(correctAnswer == 0)
        goals[1].name = "incorrect";

        result[correctAnswer].text = names[index[iterator]].ToString();
        iterator +=1;
        for(int i =0; i <=1; i++)
        {
            if(i != correctAnswer)
            {
                result[i].text = wrong.ToString();
            }
        }
        }
        
    }

     void Shuffle(int[] array){
    int p = 6;
    
    for (int n = p-1; n > 0 ; n--)
    {
        int r = Random.Range(0, n);
        int t = array[r];
        array[r] = array[n];
        array[n] = t;
    }
   
}
    public void spawn(){
           for(int i =0; i < index.Length; i++)
        {
            Debug.Log(index[i]);
        }
        Instantiate(prefabs[index[iterator]],new Vector3(0,3.7f,0),Quaternion.identity);
   

    }
}
