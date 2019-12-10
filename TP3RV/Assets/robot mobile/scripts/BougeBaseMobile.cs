using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BougeBaseMobile : MonoBehaviour
{

    public Vector3 increment;
    public float rotationSpeed;

    public GameObject O0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(increment.x != 0)
        {
            O0.transform.Translate(increment);
        }
        if (increment.y != 0)
        {
            O0.transform.Rotate(new Vector3(0.0f, increment.y*rotationSpeed,0.0f));
        }

    }
}
