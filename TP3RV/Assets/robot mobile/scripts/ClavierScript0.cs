using UnityEngine;
using System.Collections;


public class ClavierScript0 : MonoBehaviour {
    public MaterielScript materiel_script=null;
    public const float inc_step = 0.01F;

    private Vector3 new_increment;
	// Use this for initialization
	void Start () { 
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        string aux;
        //bool key_ok = false;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            new_increment = new Vector3(inc_step, 0.0F, 0.0F);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            new_increment = new Vector3(-inc_step, 0.0F, 0.0F);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            new_increment = new Vector3(0.0F, -inc_step, 0.0F);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            new_increment = new Vector3(0.0F, inc_step, 0.0F);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            new_increment = new Vector3(0.0F, 0.0F, -inc_step);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            new_increment = new Vector3(0.0F, 0.0F, inc_step);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) ||
                 Input.GetKeyUp(KeyCode.DownArrow) ||
                 Input.GetKeyUp(KeyCode.LeftArrow) ||
                 Input.GetKeyUp(KeyCode.RightArrow) ||
                 Input.GetKeyUp(KeyCode.A) ||
                 Input.GetKeyUp(KeyCode.Z))
        {
            new_increment = new Vector3(0.0F, 0.0F, 0.0F);
        }
        else
        {
            //new_increment = new Vector3(0.0F, 0.0F, 0.0F);
            //Debug.Log("Touche incorrecte!");
        }

        
        
        //if (new_increment.magnitude > 0.0F)
        //{
            aux = "increment = [" + new_increment.x.ToString("0.0000") + "," + new_increment.y.ToString("0.0000") + "," + new_increment.z.ToString("0.0000") + "]";
            //Debug.Log(aux);
            materiel_script.increment = new_increment;
        //}
	}
}
