using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendObjet : MonoBehaviour
{
    public GameObject opinceG;

    public GameObject opinceD;

    public MaterielScript materielScript;

    public float closeAngle;

    private GameObject _cube;

    private GameObject _parentCube;

    private SelectionnableDistScript _selectionnableDistScript;
    
    public bool isSelecting;

    // Start is called before the first frame update
    void Start()
    {
        _cube = GameObject.Find("Tcube");
        _selectionnableDistScript = _cube.GetComponent<SelectionnableDistScript>();
        _parentCube = _cube.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        isSelecting = materielScript.B2;
        if (isSelecting && _selectionnableDistScript.isSelectable)
        {
            _parentCube.transform.SetParent(transform);
            FermerPinces();
        }
        else if (!isSelecting && _selectionnableDistScript.isSelectable)
        {
            _parentCube.transform.SetParent(null);
            OuvrirPinces();
        }

    }

    void FermerPinces()
    {
        opinceG.transform.Rotate(0,0,-closeAngle);
        opinceD.transform.Rotate(0,0,closeAngle);
    }

    void OuvrirPinces()
    {
        opinceG.transform.Rotate(0,0,closeAngle);
        opinceD.transform.Rotate(0,0,closeAngle);
    }
}
