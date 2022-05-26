using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToLocation : MonoBehaviour
{
    public GameObject snapObject;
    
    // bools

    private GameObject point_2;
    

    private bool insideSnapZone;
    private bool grabbed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Line")
        {
            insideSnapZone = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Line")
        {
            insideSnapZone = false;
        }
    }
    
    void SnapObject()
    {
        if (grabbed == false && insideSnapZone == true)
        {
            snapObject.gameObject.transform.position = point_2.gameObject.transform.position;
        }
    }
}
