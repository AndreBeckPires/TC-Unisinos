
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerTri : MonoBehaviour
{
    public GameObject[] Triangulos;
    public GameObject[] changePositions;
    public GameObject[] t1;
    public GameObject[] t2;
    // Start is called before the first frame update
    void Start()
    {
        Triangulos[Random.Range(0,1)].SetActive(false);
        if(Triangulos[0].activeSelf)
        {
            //t1
            for(int i = 0; i < t1.Length; i++)
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
        }
        if(Triangulos[1].activeSelf)
        {
            //t2
            for(int i = 0; i < t2.Length; i++)
            {   
                int num = Random.Range(0, changePositions.Length);
                if(changePositions[num].activeSelf)
                {
                     t2[i].transform.position = changePositions[num].transform.position;
                     changePositions[Random.Range(0,changePositions.Length)].SetActive(false);
                }
                else{
                    i--;
                }
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
