using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
     public Text nameText;
     public Text dialogueText;
     public Image spriteRenderer;
     public Sprite[] spriteArr;
     public int currentSprite = 0;
     public bool defaultPic = true;
     public bool confusedPic = false;


     private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
          sentences = new Queue<string>(); // Cache a new spot in memory 
    }
    //void Update()
    //{
    //    ChangeSprite();
    //}

    void ChangeSprite()
    {

<<<<<<< Updated upstream
    
=======
        if(defaultPic == true)
        {
            currentSprite = 0;
        }
        else if((confusedPic == true) && (defaultPic == false))
        {
            currentSprite = 1;
        }
        spriteRenderer.sprite = spriteArr[currentSprite];
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
               EndDialogue();
               return;
          }
          string sentence = sentences.Dequeue();
          //dialogueText.text = sentence;
          StopAllCoroutines();
          StartCoroutine(TypeSentence(sentence));
     }

     IEnumerator TypeSentence(string sentence)
     {
          dialogueText.text = "";
          foreach(char letter in sentence.ToCharArray())
          {
            if(letter == '.')
            {
                confusedPic = false;
                defaultPic = true;
                ChangeSprite();
            }
            else if(letter == '?')
            {
                confusedPic = true;
                defaultPic = false;
                ChangeSprite();
            }
          }
          foreach(char letter in sentence.ToCharArray())
          {
               dialogueText.text += letter;
               yield return null;
          }
     }

     void EndDialogue() { Debug.Log("End of Conversation"); }



>>>>>>> Stashed changes
}
