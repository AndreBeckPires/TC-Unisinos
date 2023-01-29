using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnStrings : MonoBehaviour
{
    public int[] list;
    public string[] names;
   public Text[] titles;
 
    // Start is called before the first frame update
    void Start()
    {
        list = new int[]{0,1,2,3,4,5};
        names = new string[]{"Losango","Hexagono","Trapézio","Quadrado","Triângulo", "Pentágono"};
      
       
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    public void Shuffle()
    {
         for (int i = 0; i < list.Length; i++) {
             int rnd = Random.Range(0, list.Length);
            int  tempGO = list[rnd];
             list[rnd] = list[i];
             list[i] = tempGO;
         }
       
    }
   public void display(){
  
    
 for(int i =0; i < list.Length; i++)
        {
            titles[i].text = names[list[i]];
        }
   }
    
}
