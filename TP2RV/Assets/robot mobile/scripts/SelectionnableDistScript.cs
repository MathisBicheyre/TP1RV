using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SelectionnableDistScript : MonoBehaviour
{
    public bool isSelectable;
    public float selectDistance;

    private GameObject Otool;
    
    // Start is called before the first frame update
    void Start()
    {
        Otool = GameObject.Find("Otool");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Otool.transform.position) < selectDistance)
        {
            isSelectable = true;
        }
        else
        {
            isSelectable = false;
        }
    }
}
