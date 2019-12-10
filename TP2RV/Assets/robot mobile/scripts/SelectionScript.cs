using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{
    public MaterielScript Input = null;
    public gere_bras Output = null;

    public Vector3 Increment_VR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.B1)
        {
            Increment_VR = Input.increment;
            Output.increment = Increment_VR;
        }
    }
}