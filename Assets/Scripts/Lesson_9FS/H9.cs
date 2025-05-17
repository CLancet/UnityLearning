using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 练习题一 为Transform写一个拓展方法
        // 一般这种拓展方法都是写在一个静态类里面
        this.transform.Sort();// 这个是调用拓展方法
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
