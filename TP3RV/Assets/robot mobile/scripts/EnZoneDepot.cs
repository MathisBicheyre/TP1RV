using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class EnZoneDepot : MonoBehaviour
{

    public bool estEnZoneDepot;
    
    private UnityEngine.Vector3 _cubeV, _p1V, _p2V;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.name == "Depot")
        {
            estEnZoneDepot = true;
            GetComponent<Collider>().enabled = false;
        }
    }
}
