using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ItemJazz : MonoBehaviour
{
    //public AudioClip myJazz;
    public AudioSource jazzSource;

    void Start()
    {
        jazzSource = GetComponent<AudioSource>();
    }

    public void OnMouseEnter()
    {
        Debug.Log("Play_Audio");
        jazzSource.Play();
    }

    public void OnMouseExit()
    {
        Debug.Log("STOP_Audio");
        jazzSource.Stop();
    }
}
