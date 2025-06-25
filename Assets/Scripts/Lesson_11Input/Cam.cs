using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform target;     // 拖入 Tank 的 Transform
    public Vector3 offset = new Vector3(-5, 5, 0); // 摄像机距离 Tank 的相对位置

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(1))
        //{
            
        //}
    }


    void LateUpdate()
    {
        if (target == null) return;

        // 设置摄像机的位置
        // transform.position = target.position + offset;
        // this.transform.RotateAround(target.position, Vector3.up, 100 * Time.deltaTime);


        // 始终朝向 Tank
        transform.LookAt(target);
        // this.transform.rotation = Quaternion.Euler(30, 90, 0);


    }
}
