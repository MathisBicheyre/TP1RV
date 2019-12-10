using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class EnZoneDepot : MonoBehaviour
{

    public bool estEnZoneDepot;

    public GameObject p1, p2;

    private UnityEngine.Vector3 _cubeV, _p1V, _p2V;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _cubeV = transform.position;
        _p1V = p1.transform.position;
        _p2V = p2.transform.position;
        
        if (_cubeV.x < _p2V.x &&
            _cubeV.z < _p2V.z &&
            _cubeV.x > _p1V.x &&
            _cubeV.z > _p1V.z)
        {
            estEnZoneDepot = true;
        }
        else
        {
            estEnZoneDepot = false;
        }
    }
}
