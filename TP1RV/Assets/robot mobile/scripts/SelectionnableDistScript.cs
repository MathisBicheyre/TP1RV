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

    }

	private void OnTriggerEnter(Collider other)
	{
		if (other == tool.GetComponent<Collider>())
		{
			EstSelectionnable = true;
			Debug.Log("Woohoo");
		}
		Debug.Log("Collision detected with " + other.name);
	}

	private void OnTriggerStay(Collider other)
	{
		if (other == tool.GetComponent<Collider>())
			EstSelectionnable = true;
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == tool.GetComponent<Collider>())
			EstSelectionnable = false;
	}
}
