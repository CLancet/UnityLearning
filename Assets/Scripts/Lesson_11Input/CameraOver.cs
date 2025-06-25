using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform target; // 目标物体
    public Vector3 offset  = new Vector3 (0,0,5); // 相机与目标物体的偏移量
    private void LateUpdate()
    {
        this.transform.position = target.position + offset; // 设置相机位置为目标物体位置加上偏移量
        this.transform.LookAt(target); // 让相机始终朝向目标物体
    }
}
