using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToColor : MonoBehaviour
{
    public Color SelectColor;
    public Color DefaultColor;

    public SelectionnableDistScript isSelectable;
    
    private GameObject cube;
    
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("cube");
        changeColor(DefaultColor);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelectable.isSelectable == true)
        {
            changeColor(SelectColor);
        }
        else
        {
            changeColor(DefaultColor);
        }
    }

    void changeColor(Color color)
    {
        cube.GetComponent<Renderer>().material.color = color;
    }
    
}
