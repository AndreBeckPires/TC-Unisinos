
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
    // Start is called before the first frame update
    void Start()
    {   
        Triangulos[0].SetActive(false);
        Triangulos[1].SetActive(false);
        Triangulos[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawn(){
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
    }
}
