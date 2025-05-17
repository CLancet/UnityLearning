using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(1, 0, -1);
        // CreateEmpty();
        CreateSphere();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void CreateEmpty()
    //{
    //    GameObject empty = new GameObject("Target");
    //    Vector3 known= this.transform.position;
    //    known.x -= 1;
    //    known.z += 1;
    //    empty.transform.position = known;
    //}

    [ContextMenu("左前方创建空物体")]
    void CreateEmpty()
    {
        Vector3 pos = this.transform.TransformPoint(new Vector3(-1, 0, -1));
        GameObject empty = new GameObject("Target");
        empty.transform.position = pos;
    }

    [ContextMenu("前方创建三个球")]
    void CreateSphere()
    {
        GameObject sphere1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject sphere3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere1.transform.position = this.transform.TransformPoint(new Vector3(0,0,1));
        sphere2.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 2));
        sphere3.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 3));
    }

    //void CreateSphere() 
    //{
    //    GameObject sphere1 =GameObject.CreatePrimitive(PrimitiveType.Sphere);
    //    GameObject sphere2 =GameObject.CreatePrimitive(PrimitiveType.Sphere);
    //    GameObject sphere3 =GameObject.CreatePrimitive(PrimitiveType.Sphere);
    //    Vector3 known = this.transform.position;
    //    Vector3 s1 = new Vector3(known.x , known.y, known.z + 1);
    //    Vector3 s2 = new Vector3(known.x, known.y, known.z + 2);
    //    Vector3 s3 = new Vector3(known.x, known.y, known.z + 3);
    //    sphere1.transform.position = s1;
    //    sphere2.transform.position = s2;
    //    sphere3.transform.position = s3;
    //}
}
