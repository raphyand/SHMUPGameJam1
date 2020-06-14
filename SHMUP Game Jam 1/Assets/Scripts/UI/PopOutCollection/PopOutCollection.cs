using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopOutCollection : MonoBehaviour
{

     public Animator myAnimator;
     bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
          isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void setOpenClose()
     {
          if (isOpen == false)
               isOpen = true;
          else isOpen = false;

          myAnimator.SetBool("isOpen", isOpen);

     }


}
