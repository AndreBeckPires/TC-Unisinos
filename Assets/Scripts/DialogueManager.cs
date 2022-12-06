
using System.ComponentModel.Design;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameTxt, dialogueTxt;
    private Queue<string> sentences;
    public Animator animator;
    public GameObject button;
    public GameObject pointsToWin;
    public GameObject triggerGame;
    public GameObject spawnerObj;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();   
    }

    public void StartDialogue(Dialogue dialogue){
        
        animator.SetBool("isOpen", true);
        
        nameTxt.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count ==0)
        {
            Debug.Log("entrou3");
            EndDialoge();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
       
    }

    IEnumerator TypeSentence (string sentence){
        dialogueTxt.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueTxt.text += letter;
            yield return null;
        }
    }

    void EndDialoge()
    {
        if(spawnerObj != null)
        {
        Debug.Log("entrou spawn");
        spawnerObj.GetComponent<spawnerTri>().spawn();
        }

        animator.SetBool("isOpen", false);
        button.SetActive(false);
        
        if(pointsToWin != null)
        {
            Debug.Log("entrou1");
             pointsToWin.GetComponent<pointsToWin>().setTimer(8);
        }
        if(triggerGame != null)
        {
            Debug.Log("entrou2");
             triggerGame.GetComponent<spawnercolorchanger>().start();
        }
        


        
    
    }
    // Update is called once per frame
    
}
