using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionnableDistScript : MonoBehaviour
{
	public GameObject cube;
	public GameObject tool;
	public bool EstSelectionnable;

    // Start is called before the first frame update
    void Start()
    {
		tool = GameObject.Find("Otool");
	}

    // Update is called once per frame
    void Update()
    {
		print(Vector3.Distance(tool.transform.position, cube.transform.position));
		if (Vector3.Distance(tool.transform.position, cube.transform.position) < 1)
			EstSelectionnable = true;
		else
			EstSelectionnable = false;
    }
}
