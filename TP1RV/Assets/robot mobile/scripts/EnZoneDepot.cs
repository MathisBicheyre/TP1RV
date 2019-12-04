using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnZoneDepot : MonoBehaviour
{
	public GameObject cube;
	public bool estEnZoneDepot;
	private Vector2 p1 = new Vector2(2, 2);
	private Vector2 p2 = new Vector2(2, 3);
	private Vector2 p3 = new Vector2(3, 2);
	private Vector2 p4 = new Vector2(3, 3);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//2..2 2..3 3..2 3..3
        if (cube.transform.position.x < 3 && cube.transform.position.x > 2 && cube.transform.position.z < 3 && cube.transform.position.z > 2)
		{
			estEnZoneDepot = true;
		}
    }
}
