using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourisScript : MonoBehaviour
{
    public MaterielScript materiel_script=null;
    private bool B1, B2, B3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string aux;
        //bool key_ok = false;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            B1 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            B2 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            B3 = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            B1 = false;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            B2 = false;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse2))
        {
            B3 = false;
        }
        else
        {
            //Debug.Log("Touche incorrecte!");
        }
        //if ((B1||B2)||B3)
        //{
            aux = "B1,B2,B3 = [" + B1.ToString() + "," + B2.ToString() + "," + B3.ToString() + "]";
            Debug.Log(aux);
            materiel_script.B1 = B1;
            materiel_script.B2 = B2;
            materiel_script.B3 = B3;
        //}
    }
}
