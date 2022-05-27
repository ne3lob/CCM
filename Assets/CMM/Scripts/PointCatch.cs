using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCatch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LeftHand")
        {
            Debug.Log("Left Hand");
        }
        
        if (collision.gameObject.tag == "RightHand")
        {
            Debug.Log("Right Hand");
        }
    }
}
