using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punkte : MonoBehaviour
{
    [SerializeField] private GameObject[] points;
    private List<GameObject> toEnable = new List<GameObject>();
    [SerializeField] private Material[] pickMaterial;

    public bool pickPoints;
    private GameObject point;
    private int index;
    private int pointsOn_Count;
    
    // Start is called before the first frame update
    void Start()
    {
        pointsOn_Count = 2;
        foreach (var p in points)
        {
            toEnable.Add(p);
            p.GetComponent<MeshRenderer>().material = pickMaterial[Random.Range(0, pickMaterial.Length)];

            //p.GetComponent<MeshRenderer>().enabled = false;
        }
        Debug.Log(toEnable.Count);
        index = Random.Range(0, points.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (pickPoints)
        {
            LightOn();
        }
        
        DisablePoints();
    }

    private void LightOn()
    {
        GameObject pickPoint = toEnable[Random.Range(0, toEnable.Count)];
        pickPoint.SetActive(true);
        toEnable.Remove(pickPoint);
        pickPoints = false;
        
        Debug.Log(toEnable.Count);
    }

    private void DisablePoints()
    {
        foreach (var p in toEnable)
        {
            p.SetActive(false);
        }
    }
}
