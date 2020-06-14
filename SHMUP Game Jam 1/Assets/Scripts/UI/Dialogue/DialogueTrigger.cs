using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
     public Dialogue dialogue;
     [SerializeField]
     GameObject ui_Holder;
     [SerializeField]
     Item myItem;

     void Update()
     {
          exitDialogue();
     }

     void Start()
     {
          ui_Holder.SetActive(false);
     }

     // Start is called before the first frame update
     void OnMouseDown()
     {
          if (CompareTag("Interactable"))
          {
               ui_Holder.SetActive(true);
               TriggerDialogue();
               myItem.setIsFound(true);
          }
          else
          {
               Debug.Log("Not pressing on interactable");
               ui_Holder.SetActive(false);
          }
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
