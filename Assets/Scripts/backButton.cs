using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour
{

     Scene scene;
    // Start is called before the first frame update
    void Start()
    {
         scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(scene.name);
    }
    
    public void  goBack(){
        if(scene.name == "triopitagorico")
        {
            SceneManager.LoadScene("town D");
        }
        if(scene.name == "SampleScene")
        {
            SceneManager.LoadScene("town M");
        }
        if(scene.name == "minigame2")
        {
            Debug.Log("entrou");
            SceneManager.LoadScene("town E");
        }
    }
}
