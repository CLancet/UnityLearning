using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H16 : MonoBehaviour
{
    // 碰撞练习题
    // 1.点击鼠标左键发射一个子弹
    // 2.子弹碰到地面（plane）时销毁子弹
    // 3.在场景中加入一些立方体，每个立方体被打3次后销毁
    // Start is called before the first frame update

    #region 构思过程
    // 首先需要创建一个子弹预制体
    // 子弹预制体需要有一个刚体组件
    // 子弹预制体需要有一个碰撞器组件
    // 子弹预制体需要有一个脚本组件
    // 脚本组件需要有一个发射函数，此处可以使用 Update 函数来检测鼠标左键点击事件
    // 发射函数需要实例化子弹预制体
    // 发射函数需要给子弹添加一个向前的力？或者直接让子弹按照一定的速度前进
    // 子弹脚本需要有一个碰撞检测函数
    // 碰撞检测函数需要判断碰撞的对象是否是地面（plane）
    // 如果是地面，则销毁子弹
    // 碰撞检测函数需要判断碰撞的对象是否是立方体
    // 如果是立方体，则立方体的被打次数加1

    // 重难点问题：如何设计子弹的发射方向？
    // 可以使用摄像机的前方向量作为子弹的发射方向
    // 也可以使用鼠标点击位置的世界坐标作为子弹的发射方向，两种都试试
    // [SerializeField]
    //这个东西的作用是将这个变量暴露在 Unity 编辑器中，即使它是私有的

    #endregion
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
