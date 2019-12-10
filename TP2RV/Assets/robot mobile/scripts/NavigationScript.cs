using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour
{
    public MaterielScript Input = null;

    public BougeBaseMobile Output = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.B1)
        {
            Output.increment = Input.increment;
        }
    }
}
