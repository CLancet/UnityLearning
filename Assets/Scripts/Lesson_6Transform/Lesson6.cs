using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region Transform
        #endregion

        #region 知识点一 Vector3
        // Vector3是一个三维向量 是一个结构体
        Vector3 vector3 = new Vector3(1, 2, 3);// 有参构造 如果只传一个参数，其他两个参数会默认等于0
        Vector3 vector3_1 = new Vector3(); // 无参构造
        // 赋值
        vector3_1.x = 1;
        vector3_1.y = 2;
        vector3_1.z = 3;
        // vector基本计算
        // 加法
        Vector3 vector3_2 = vector3 + vector3_1;
        // 减法
        Vector3 vector3_3 = vector3 - vector3_1;
        // 乘法
        Vector3 vector3_4 = vector3 * 3.0f;
        // 除法
        Vector3 vector3_5 = vector3 / 3.0f;

        // 常用的向量（静态属性）
        print(Vector3.zero);
        print(Vector3.right);//100
        print(Vector3.left);//-100
        print(Vector3.up);//010
        print(Vector3.down);//0-10
        print(Vector3.forward);//001 面朝向
        print(Vector3.back);//00-1 背朝向

        // 常用方法 计算两个点之间的距离
        float distance = Vector3.Distance(vector3, vector3_1); // 计算两个点之间的距离
        #endregion


        #region 知识点二 位置
        // 相对世界坐标系
        print(this.gameObject.transform.position);// this.transform.position
        // 相对父物体坐标系
        print(this.gameObject.transform.localPosition);// this.transform.localPosition

        //位置的赋值不能直接改变xyz,只能整体改变
        this.transform.position = new Vector3(1, 2, 3);

        // 物体的各个朝向
        print(this.gameObject.transform.forward); // 前方 用世界坐标系表示当前对象的朝向
        print(this.gameObject.transform.right); // 右方 用世界坐标系表示当前对象的朝向
        print(this.gameObject.transform.up); // 上方 用世界坐标系表示当前对象的朝向


        #endregion




    }

    // Update is called once per frame
    void Update()
    {
        #region 知识点三 位移 this.transform.xxword得到的方向都是基于世界坐标系的

        // 物体的位移 方向*速度*时间
        //方式一 自己手搓 当前的位置加上要移动的距离
        //this.transform.position += this.transform.forward * 3.0f * Time.deltaTime;
        // this.transform.position += this.transform.forward * 3.0f * Time.deltaTime + this.transform.right * 3.0f * Time.deltaTime;
        // 方式二 使用API,一般使用API来移动物体
        // 参数一 ：表示位移多少
        // 参数二 ：表示相对坐标系,默认该参数是自己的坐标系
        // 相对于世界坐标系的自己的面朝向去移动
        // this.transform.Translate(this.transform.forward * 3.0f * Time.deltaTime, Space.World);
        //效果等同
        this.transform.Translate(Vector3.forward*3*Time.deltaTime,Space.Self);

        #endregion

        //总结
        // Vector3
        // 如何申明，常用静态属性，计算距离的方法，位置，世界坐标系和局部坐标系
        // 不能单独修改xyz
        // 位移的计算
    }
}
