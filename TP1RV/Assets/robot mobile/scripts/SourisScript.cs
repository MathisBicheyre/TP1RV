using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourisScript : MonoBehaviour
{
	public MaterielScript mat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		mat.B1 = Input.GetButton("Fire1");
		mat.B2 = Input.GetButton("Fire2");
		mat.B3 = Input.GetButton("Fire3");
	}
}
