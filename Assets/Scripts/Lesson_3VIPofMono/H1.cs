using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H1 : MonoBehaviour
{
    public H2 h2;
    // Start is called before the first frame update
    void Start()
    {
        if(h2!= null)
            h2.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
