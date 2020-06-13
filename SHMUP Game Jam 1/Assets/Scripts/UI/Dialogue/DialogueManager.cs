using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
     public Text nameText;
     public Text dialogueText;

     private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
          sentences = new Queue<string>(); // Cache a new spot in memory 
    }

    
}
