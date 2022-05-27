using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punkte : MonoBehaviour
{
    [SerializeField] private GameObject[] points;
    private GameObject point;
    private int index;
    private int pointsOnCount;
    
    // Start is called before the first frame update
    void Start()
    {
        pointsOnCount = 2;
        foreach (var p in points)
        {
            p.GetComponent<MeshRenderer>().enabled = false;
        }

        index = Random.Range(0, points.Length);
    }

    // Update is called once per frame
    void Update()
    {
        LightOn();
    }

    private void LightOn()
    {
        
    }
}
