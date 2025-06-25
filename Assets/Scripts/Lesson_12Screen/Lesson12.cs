using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 获取当前屏幕分辨率
        Resolution r = Screen.currentResolution;
        print("当前屏幕的宽"+r.width+"当前屏幕的高"+r.height);// 设备窗口的大小

        print(Screen.width);//当前game窗口的宽度,unity中的game窗口可以自己改，，写代码要用宽高时使用这个

        // 屏幕休眠模式
        Screen.sleepTimeout = SleepTimeout.NeverSleep; // 永不休眠



        // 设置全屏模式
        Screen.fullScreen = true;
        // 窗口模式
        // 独占全屏
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;


        // 设置分辨率
        // 移动设备不使用
        // Screen.SetResolution(1, 1,false);// 第三个参数是是否全屏

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
