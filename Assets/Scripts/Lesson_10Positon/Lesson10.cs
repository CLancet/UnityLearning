using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 世界坐标转本地坐标
        print(Vector3.forward);
        // 世界坐标系的点转换为本地坐标系的点

        // 1.受到缩放影响
        // 当物体的scale为0.5时，世界坐标系下的一格在本地坐标系会变成两格
        // 物体在（1,0,1），世界坐标系下的（0,0,1）相对于本地的坐标
        // 如果物体的scale为0.5
        // position after trans(-1.41, 0.00, -1.41)
        // 如果物体的scale为1
        // position after trans(-0.71, 0.00, -0.71)
        print("position after trans"+this.transform.InverseTransformPoint(Vector3.forward));



        // 2.不受缩放影响


        // 世界坐标系的方向 转换为相对于本地坐标系的方向
        // 1.受缩放影响
        // 方向的相对位置，平移方向向量的起始点，放到物体坐标系的原点
        // 物体的scale是0.5
        // 原方向向量（0,0,1）
        // 物体位置（1,0,1）
        // 在物体坐标系下的方向向量(-1.41, 0.00, 1.41)
        // 收到scale影响，原来的向量长度为1，物体缩放比例为0.5，缩放后长度为2
        print("direction after transform affected by scale" + this.transform.InverseTransformVector(Vector3.forward));


        // 2.不受缩放影响
        // 方向的相对位置，平移方向向量的起始点，放到物体坐标系的原点
        // 不管物体的scale是多少
        // 原方向向量（0,0,1）
        // 物体位置（1,0,1）
        // 在物体坐标系下的方向向量 direction after transform(-0.71, 0.00, 0.71)
        print("direction after transform" + this.transform.InverseTransformDirection(Vector3.forward));

        #endregion

        #region 知识点二 本地坐标转世界坐标
        // 点的转化
        // 会受到缩放影响
        // 这个很重要！！！！
        print("local->glabal" + this.transform.TransformPoint(Vector3.forward));

        // 方向的转化
        // 1.受缩放影响
        // 方向的相对位置，平移方向向量的起始点，放到物体坐标系的原点
        print("local->glabal" + this.transform.TransformVector(Vector3.forward));
        // 2.不受缩放影响
        // 方向的相对位置，平移方向向量的起始点，放到物体坐标系的原点
        print("local->glabal" + this.transform.TransformDirection(Vector3.forward));


        #endregion


        // 总结
        // 其中最重要的就是 本地坐标系的点转化为世界坐标系的点
        // 比如玩家现在要在自己面前的n个单位处放一个物体，这些物体不会作为玩家的子对象
        // 这个时候我们不用去计算世界坐标系的点
        // 直接使用本地坐标系的点，然后转化为世界坐标系的点即可，
        // 再在世界坐标系下放置物体/特效创建/攻击范围判断
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
