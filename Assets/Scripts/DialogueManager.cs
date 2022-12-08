
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
    public GameObject playButton;
    public bool isPlaying;
    public GameObject front;
    public GameObject[] alvos;
    public GameObject[] plates;
    public GameObject[] lever;
    // Start is called before the first frame update
    void Start()
    {
        isPlaying = false;
        sentences = new Queue<string>();
        for(int i =0; i < alvos.Length; i++)
        {
            alvos[i].SetActive(false);
        }
        for(int i =0; i < plates.Length; i++)
        {
            plates[i].SetActive(false);
        }
        for(int i =0; i < lever.Length; i++)
        {
            lever[i].SetActive(false);
        }
        front.SetActive(false);

        if(button != null)
        {
            Debug.Log("button");
        }
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
            
            EndDialoge();
            isPlaying = true;
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

        
       
        animator.SetBool("isOpen", false);
        button.SetActive(false);
      
        if(front != null)
        {
            for(int i =0; i < alvos.Length; i++)
            {
                alvos[i].SetActive(true);
            }
            for(int i =0; i < plates.Length; i++)
            {
                plates[i].SetActive(true);
            }
            for(int i =0; i < lever.Length; i++)
            {
                lever[i].SetActive(true);
            }
            front.SetActive(true);
        }
           

        
        if(pointsToWin != null)
        {
            
             pointsToWin.GetComponent<pointsToWin>().setTimer(10);
        }
        if(triggerGame != null)
        {

             triggerGame.GetComponent<spawnercolorchanger>().start();
        }
        


        
    
    }
    // Update is called once per frame
    
}
