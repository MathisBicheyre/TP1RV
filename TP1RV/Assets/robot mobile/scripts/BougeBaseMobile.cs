using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BougeBaseMobile : MonoBehaviour
{
	public NavigationScript nav;
	public GameObject O0;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		O0.transform.Translate(nav.vec.x, 0.0f, 0.0f);
		O0.transform.Rotate(0.0f, nav.vec.y, 0.0f);
	}
}
