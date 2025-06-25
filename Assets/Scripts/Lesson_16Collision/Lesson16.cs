using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    #region 物理碰撞检测函数
    // 类似于生命周期函数
    // 当物体与其他物体发生碰撞时调用

    // Collision 类型的参数包含了碰到自己的对象的信息
    // 例如碰撞的对象碰撞器信息
    // 碰撞对象的依附对象GameObject
    // 碰撞对象的依附对象Transform
    // 碰撞的接触点信息（点数，坐标，法线等）collision.contacts;
    // 
    private void OnCollisionEnter(Collision collision)
    {
        // 当发生碰撞时调用
        Debug.Log("发生碰撞: " + collision.gameObject.name);
    }

    // 当物体与其他物体碰撞时持续调用
    private void OnCollisionStay(Collision collision)
    {
        // 当持续碰撞时调用
        Debug.Log("持续碰撞: " + collision.gameObject.name);
    }
    // 当物体与其他物体分离时调用
    private void OnCollisionExit(Collision collision)
    {
        // 当分离时调用
        Debug.Log("分离碰撞: " + collision.gameObject.name);
    }
    #endregion

    #region 触发器碰撞检测函数
    // 触发开始的时候调用
    private void OnTriggerEnter(Collider other)
    {
        // 当触发器开始触发时调用
        Debug.Log("触发器开始触发: " + other.gameObject.name);
    }
    private void OnTriggerStay(Collider other)
    {
        // 当触发器持续触发时调用
        Debug.Log("触发器持续触发: " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        // 当触发器停止触发时调用
        Debug.Log("触发器停止触发: " + other.gameObject.name);
    }
    #endregion

    #region 什么时候会相应函数
    // 只要挂载的对象能和别的物体产生碰撞或者触发
    #endregion

    #region 碰撞函数和触发函数都可以写成虚函数
    // 只要挂载的对象能和别的物体产生碰撞或者触发
    // protected virtual void OnCollisionEnter(Collision collision)
    //{
        // 当发生碰撞时调用
        // Debug.Log("发生碰撞: " + collision.gameObject.name);
    //} 
#endregion

// Update is called once per frame
void Update()
    {

    }
}

