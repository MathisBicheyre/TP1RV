using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toColour : MonoBehaviour
{
	public GameObject cube;
	public SelectionnableDistScript selectionnable;

	// Start is called before the first frame update
	void Start()
    {
		cube = GameObject.Find("cube");
		toColor(Color.gray);
		
	}

    // Update is called once per frame
    void Update()
    {
		if (selectionnable.EstSelectionnable)
			toColor(Color.blue);
		else
			toColor(Color.gray);

	}

	void toColor(Color color)
	{
		cube.GetComponent<Renderer>().material.color = color;

	}
}
