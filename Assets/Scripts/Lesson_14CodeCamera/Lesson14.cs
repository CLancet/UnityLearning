using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 获取摄像机
        // 主摄像机获取
        // 要求场景中的摄像机的tag必须是"MainCamera"
        Camera cam = Camera.main;
        // 获取当前摄像机的数量
        int cameraCount = Camera.allCamerasCount;
        // 得到所有摄像机
        Camera[] cameras = Camera.allCameras;


        //2.渲染相关委托
        // 摄像机剔除前处理的委托函数
        Camera.onPreCull += (c)=>
        {
        };

        // 摄像机渲染前处理的委托函数
        Camera.onPreRender += (c) =>
        {
        };
        // 摄像机渲染后处理的委托函数
        Camera.onPostRender += (c) =>
        {
            // 在摄像机渲染后执行的代码
            // 例如：绘制一些UI元素或特效
        };

        #region 知识点2 重要成员
        //界面上的参数都可以通过代码来设置
        //2.世界坐标转屏幕坐标
        //用来做血条最常见
        //这个是挂载在物体上的脚本，获取物体的世界坐标然后转为屏幕坐标，z轴表示这个3D物体距离摄像机的远近
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position); 
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //屏幕坐标转世界坐标
        // 要改变z轴，因为如果z轴不改，则z默认为0，转换到世界坐标时会变成摄像机的坐标
        // 可以理解为视口相交的点
        // 如果改变了z轴，那么转换过去的点就是相对于摄像机前方多少的单位的横截面上的世界坐标点
    }
}
