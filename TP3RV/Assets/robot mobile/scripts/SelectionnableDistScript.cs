using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SelectionnableDistScript : MonoBehaviour
{
    public bool isSelectable;


    private GameObject Otool;
    
    // Start is called before the first frame update
    void Start()
    {
        Otool = GameObject.Find("Otool");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        isSelectable = true;
        Debug.Log(other.name + "Entré");
    }

    private void OnTriggerExit(Collider other)
    {
        isSelectable = false;
        Debug.Log(other.name + "Sorti");
    }
}
