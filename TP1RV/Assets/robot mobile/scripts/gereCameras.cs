using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gereCameras : MonoBehaviour
{
	public PrendObjet prend;
	public MaterielScript mat;
	public Camera egocentrique1;
	public Camera egocentrique2;
	public Camera exocentrique1;

	public GameObject player;

	private Camera[] liste;
	private int courante;

	// Use this for initialization
	void Start()
	{
		liste = new Camera[3];
		egocentrique1.transform.parent = player.transform;
		egocentrique2.transform.parent = player.transform;
		liste[0] = egocentrique1;
		liste[1] = egocentrique2;
		liste[2] = exocentrique1;
		courante = 0;
	}


	public void Switch()
	{
		liste[courante % 3].enabled = false;
		courante++;
		liste[courante % 3].enabled = true;
	}
}
