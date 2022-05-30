using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using Oculus.Interaction.PoseDetection;
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

    private ActiveStateUnityEventWrapper ActiveStateUnityEventWrapper;
    
    // Start is called before the first frame update
    void Start()
    {
        
      //  pointsOn_Count = 2;
        foreach (var p in points)
        {
            toEnable.Add(p);
            p.GetComponent<MeshRenderer>().sharedMaterial = pickMaterial[Random.Range(0, pickMaterial.Length)];
            if (p.GetComponent<MeshRenderer>().sharedMaterial == pickMaterial[0])
            {
                Debug.Log(pickMaterial[0]);
                p.gameObject.tag = "RedPoint";
            }
            else if (p.GetComponent<MeshRenderer>().sharedMaterial == pickMaterial[1])
            {
                p.gameObject.tag = "BluePoint";
            }
            
            //p.GetComponent<MeshRenderer>().enabled = false;
        }
        Debug.Log(toEnable.Count);
        index = Random.Range(0, points.Length);
    }

    // Update is called once per frame
    void Update()
    {
        //TODO DELETE IT FROM UPDATE
        
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
        
        Debug.Log("List toEnable: "+toEnable.Count);
    }

    private void DisablePoints()
    {
        foreach (var p in toEnable)
        {
            p.SetActive(false);
        }
    }

     public void Pick()
     {
         pickPoints =true;
     }

     public void ChechMat()
     {
         ;
         
     }
     
}
