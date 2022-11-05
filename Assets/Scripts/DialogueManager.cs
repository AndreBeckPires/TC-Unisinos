
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
        animator.SetBool("isOpen", false);
       
    }
    // Update is called once per frame
    
}
