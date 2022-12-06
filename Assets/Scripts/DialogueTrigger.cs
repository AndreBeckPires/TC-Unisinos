using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger : MonoBehaviour
{
    public GameObject buttonInit;
    // Start is called before the first frame update
    public Dialogue dialogue;
    void Awake()
    {
        
    }
    public void TriggerDialogue(){
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        buttonInit.SetActive(false);
    }
}
