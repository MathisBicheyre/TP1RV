using UnityEngine;
using System.Collections;

public class GereCameras : MonoBehaviour {
	
	public Camera exocentrique1;
	public Camera exocentrique2;
	public Camera egocentrique;
	public MaterielScript materielScript;

	// Use this for initialization
	void Start()
	{
		exocentrique1.enabled = false;
		exocentrique2.enabled = true;
		egocentrique.enabled = false;
	}

	void Switch(int camera)
	{
		switch (camera)
		{
			case 1:
				exocentrique1.enabled = true;
				exocentrique2.enabled = false;
				egocentrique.enabled = false;
				break;
			case 2:
				exocentrique1.enabled = false;
				exocentrique2.enabled = true;
				egocentrique.enabled = false;
				break;
			case 3:
				exocentrique1.enabled = false;
				exocentrique2.enabled = false;
				egocentrique.enabled = true;
				break;
		}
	}

	// Update is called once per frame
	void Update () {
		if (materielScript.B3)
		{
			Switch(3);
		}
		else if(materielScript.B1)
		{
			Switch(1);
		}
		else
		{
			Switch(2);
		}
	}
}
