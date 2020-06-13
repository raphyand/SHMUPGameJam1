using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour
{
    public Transform cameraPosition;
    public List<Node> reachableNodes = new List<Node>();
    [HideInInspector] public Collider2D col;


    void Start()
    {
        col = GetComponent<Collider2D>();
    }

}
