
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerTri : MonoBehaviour
{
    public GameObject[] Triangulos;
    public GameObject[] changePositions;
    public GameObject[] t1;
    public GameObject[] t2;
    public GameObject[] t3;
    public GameObject[] squares;
    public GameObject buttonTeste;
    public bool playing;
   int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8};

    
    // Start is called before the first frame update
    void Start()
    {   
        

        
        playing = false;
        Shuffle(array);
     //  print(array);
       spawn(array);
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }
   /* public void spawn(){
        Triangulos[0].SetActive(true);
        Triangulos[1].SetActive(true);
        Triangulos[2].SetActive(true);
        Debug.Log("entrou");
        for(int i = 0; i < squares.Length; i++)
            {   
                int num = Random.Range(0, changePositions.Length);
                if(changePositions[num].activeSelf)
                {
                     t1[i].transform.position = changePositions[num].transform.position;
                     changePositions[Random.Range(0,changePositions.Length)].SetActive(false);
                }
                else{
                    i--;
                }
            }
    }*/
    public void spawn(int[] array){
        for(int i =0; i < squares.Length; i++)
        {
            Debug.Log(array[i]);
            squares[i].transform.position = changePositions[array[i]].transform.position;

        }
    }
    void Shuffle(int[] array){
    int p = array.Length;
    
    for (int n = p-1; n > 0 ; n--)
    {
        int r = Random.Range(1, n);
        int t = array[r];
        array[r] = array[n];
        array[n] = t;
    }
   
}
 void print(int[] array){
    
        for(int i = 0; i < array.Length; i++ )
        {
           Debug.Log(array[i]);
        }
    }
    
}
