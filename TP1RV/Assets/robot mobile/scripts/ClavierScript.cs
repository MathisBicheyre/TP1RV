using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClavierScript : MonoBehaviour
{
	public MaterielScript mat;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		mat.increment_IR = clavier();
	}

	public Vector3 clavier()
	{
		Vector3 vector = new Vector3(0.0F, 0.0F, 0.0F);

		if (Input.GetKey(KeyCode.RightArrow))
			vector.y += (float)0.5;
		if (Input.GetKey(KeyCode.LeftArrow))
			vector.y -= (float)0.5;
		if (Input.GetKey(KeyCode.UpArrow))
			vector.x += (float)0.1;
		if (Input.GetKey(KeyCode.DownArrow))
			vector.x -= (float)0.1;
		if (Input.GetKey(KeyCode.A))
			vector.z += (float)0.1;
		if (Input.GetKey(KeyCode.Z))
			vector.z -= (float)0.1;

		return vector;
	}
}
