using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeMinigames : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void mg1()
    {
        SceneManager.LoadScene("SampleScene");
    }
       public void mg2()
    {
        SceneManager.LoadScene("minigame2");
    }

    public void goMenu()
    {
        SceneManager.LoadScene("town");
    }
}
