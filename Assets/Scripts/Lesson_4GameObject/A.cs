using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum OP
{
    change_name,
    activeornor,
    destroy,
    destrotImmidately
}

public class A : MonoBehaviour
{
    public OP op = OP.change_name;
    public GameObject B;
    // Start is called before the first frame update
    void Start()
    {
        switch (op)
        {
            case OP.change_name:
                B.name = "小小白";
                break;
            case OP.activeornor:
                B.SetActive(false);
                break;
            case OP.destroy:
                Destroy(B);
                break;
            case OP.destrotImmidately:
                DestroyImmediate(B);
                break;
        }
        // obj.GetComponent<B>().enabled = false;
        // obj.name = "小小白";
        // DestroyImmediate( obj );
        // obj.SetActive(false);
        // if(obj != null )
        // print(obj.name);
        //GameObject obj = GameObject.Find("H4B");
        //if(obj != null)
        //{
        //    B b = obj.GetComponent<B>();
        //    b.enabled = false;
        //}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
