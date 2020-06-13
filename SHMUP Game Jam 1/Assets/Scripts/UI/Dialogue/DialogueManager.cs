﻿using System.Collections;
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

    public void StartDialogue(Dialogue dialogue)
     {
          Debug.Log("Starting conversation with " + dialogue.name);
          nameText.text = dialogue.name;
          sentences.Clear();
          foreach(string sentence in dialogue.sentences)
          {
               sentences.Enqueue(sentence);
          }
          DisplayNextSentence();
     }

     public void DisplayNextSentence()
     {
          if (sentences.Count == 0)
          {

          }
     }

     IEnumerator TypeSentence(string sentence)
     {
          dialogueText.text += "";
          foreach(char letter in sentence.ToCharArray())
          {
               dialogueText.text += letter;
               yield return null;
          }
     }

     void EndDialogue() { Debug.Log("End of Conversation"); }



}
