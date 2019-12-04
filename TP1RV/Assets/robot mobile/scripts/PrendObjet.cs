using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendObjet : MonoBehaviour
{
	public GameObject pince_d;
	public GameObject pince_g;
	public GameObject cube;

	public MaterielScript mat;
	public SelectionnableDistScript selectdist;

	private Transform cube_self;
	public bool estPris;
	public bool estLachable;


	// Start is called before the first frame update
	void Start()
    {
		cube_self = cube.transform.parent;
	}

	public void Prise()
	{
		if (estPris)//Not in the graph of the TD.
		{
			if (cube.transform.position.x < 5 && cube.transform.position.y < 5 && cube.transform.position.x > -5 && cube.transform.position.y > -5)
				estLachable = true;
			else
				estLachable = false;
		}
		if (selectdist.EstSelectionnable)
		{
			if (mat.B1) //leftclick
			{
				estPris = true;
				cube.transform.parent = this.transform;
				if (pince_g.transform.localPosition.x <= -0.008)
				{
					pince_g.transform.Translate(0.001f, 0.0f, 0.0f);
					pince_d.transform.Translate(-0.001f, 0.0f, 0.0f);
				}
			}
			else if (!mat.B1 && estLachable) // trying to release the grip if not holding rightclick
			{
				estPris = false;
				estLachable = false;
				cube.transform.parent = cube_self;

				if (pince_g.transform.localPosition.x >= -0.017)
				{
					pince_g.transform.Translate(-0.001f, 0.0f, 0.0f);
					pince_d.transform.Translate(0.001f, 0.0f, 0.0f);
				}
			}
		}
	}

	// Update is called once per frame
	void Update()
	{
		Prise();
	}
}
