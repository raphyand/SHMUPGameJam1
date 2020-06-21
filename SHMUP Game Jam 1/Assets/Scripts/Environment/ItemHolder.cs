using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{

     public Item[] myItemHolder;

     static ItemHolder instance;
     void Awake()
     {
          if (instance != null)
          {
               Destroy(gameObject);
          }
          else
          {
               instance = this;
               DontDestroyOnLoad(gameObject);
          }

     }


     // Start is called before the first frame update
     void Start()
    {
          //Ui
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     
}
