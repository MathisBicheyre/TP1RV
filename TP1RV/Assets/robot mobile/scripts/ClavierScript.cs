using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClavierScript : MonoBehaviour
{
	public gere_bras gere_bras = null;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyUp(KeyCode.RightArrow))
			gere_bras.increment.x += (float)0.01;
		if (Input.GetKeyUp(KeyCode.LeftArrow))
			gere_bras.increment.x -= (float)0.01;
		if (Input.GetKeyUp(KeyCode.UpArrow))
			gere_bras.increment.y += (float)0.01;
		if (Input.GetKeyUp(KeyCode.DownArrow))
			gere_bras.increment.y -= (float)0.01;
		if (Input.GetKeyUp(KeyCode.A))
			gere_bras.increment.z += (float)0.01;
		if (Input.GetKeyUp(KeyCode.Z))
			gere_bras.increment.z -= (float)0.01;
	}
}
