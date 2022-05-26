using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectPoints : MonoBehaviour
{

    public LineRenderer line;
    public Transform snapObject;
    public Transform point_2;
    
    
    private static List<GameObject> points = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject findObj in GameObject.FindGameObjectsWithTag("Point")) {
 
            points.Add(findObj);
        }
        
        foreach(GameObject p in points)
        {
            Debug.Log(p.name);
            
        }
        
        line.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, snapObject.position);
        line.SetPosition(1, point_2.position);
    }

    

    // Snap to Location

    
    public void Respawn()
    {
        // hello
    }
}
