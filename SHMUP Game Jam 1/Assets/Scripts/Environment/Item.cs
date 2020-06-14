using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
     bool isFound;
     Image myImage;
    // Start is called before the first frame update
    void Start()
    {
          //DontDestroyOnLoad(this);
          myImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
          revealItem(); 
    }

     void revealItem()
     {
          if (isFound == false)
          {
               myImage.enabled = false;  // !myImage.enabled;
          }

          if (isFound == true)
          {
               myImage.enabled = true;
          }

     }

     public void setIsFound(bool found)
     {
          isFound = found;
     }


}
