using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
     public Dialogue dialogue;
     [SerializeField]
     GameObject ui_Holder;


     void Update()
     {
          exitDialogue();
     }


     // Start is called before the first frame update
     void OnMouseDown()
     {
          if (CompareTag("Interactable"))
          {
               ui_Holder.SetActive(true);
               TriggerDialogue();
          }
          else ui_Holder.SetActive(false);
     }

     void exitDialogue()
     {
          if (Input.GetKeyDown(KeyCode.Escape))
               ui_Holder.SetActive(false);
     }
     

     public void TriggerDialogue()
     {
          ui_Holder.SetActive(true);
          FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
     }
}
