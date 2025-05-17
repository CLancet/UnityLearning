using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // 当对象（自己这个类对象）被创建时调用，而不是gameObject创建时，这个很好理解
    // 类似构造函数的存在，在一个类对象创建的时候调用
    private void Awake()
    {
        // Print message in Unity console
        // 1.没有继承MonoBehaviour
        //Debug.Log("123");
        //Debug.LogError("Error");
        //Debug.LogWarning("Warning");
        // 2.继承MonoBehaviour，有一个线程的方法
        print("Awake");

    }

    //激活对象的时候调用，这个激活就是Inspector面板上，勾选了这个对象的复选框
    private void OnEnable()
    {
        print("OnEnable");
    }
    // Start is called before the first frame update
    // 也是用于初始化的，但是相对于Awake来说，Start是等到所有的对象都创建完了之后才会调用
    void Start()
    {
        print("Start");
    }

    // 这个主要是用于物理引擎的更新
    // FixedUpdate也是每帧调用的，但是它是固定时间间隔调用的，而不是游戏帧
    // 这个固定时间可以在Project Settings中设置
    private void FixedUpdate()
    {
        // 物理引擎的更新
        print("FixedUpdate");
    }


    // Update is called once per frame
    // 主要用于处理游戏核心逻辑更新的函数
    void Update()
    {
        print("Update");
    }

    // 这个函数是每帧最后调用的函数
    // 主要用于处理相机跟随等逻辑
    // 在Update和LateUpdate之间，Unity进行了一些处理，处理我们动画相关的更新
    private void LateUpdate()
    {

        print("LateUpdate");
    }

    // 这个函数是当对象失活的时候调用的
    // 这个禁用是指Inspector面板上，取消了这个对象的复选框
    private void OnDisable()
    {
        print("OnDisable");
    }

    // 这个函数是当对象被销毁的时候调用的
    // 这个销毁是指Destroy函数被调用，或者场景切换的时候
    private void OnDestroy()
    {
        print("OnDestroy");
    }
}


