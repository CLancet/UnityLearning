using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class H7Space : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "Sun")
        {
            // this.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
        }
        else if (this.gameObject.name == "Earth")
        {
            // 让地球围绕着太阳转动
            this.transform.RotateAround(GameObject.Find("Sun").transform.position, Vector3.up, 10 * Time.deltaTime);
            // 让地球自转
            this.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
        }
        else if (this.gameObject.name == "Moon")
        {
            // 让月球围绕着地球转动
            this.transform.RotateAround(GameObject.Find("Earth").transform.position, Vector3.up, 10 * Time.deltaTime);
            // 让月球自转
            this.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
        }
    }
}
