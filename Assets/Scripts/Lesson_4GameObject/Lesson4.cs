using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    //准备用来克隆的对象
    // 可以是场景中的对象
    // 可以是预设体
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点1 gameObject 成员变量
        // 名字
        print(this.gameObject.name);
        this.gameObject.name  = "小白"; // 结束之后又会变回原来的名字
        print(this.gameObject.name);

        //是否激活
        print(this.gameObject.activeSelf);

        //是否是静态
        print(this.gameObject.isStatic);

        //layer
        print(this.gameObject.layer);

        // tag
        print(this.gameObject.tag);

        // transform
        //this.transform get transform by Mono(script equal to gameobject.transform)
        print(this.gameObject.transform.position);
        #endregion

        #region 知识点2 gameObject中的静态方法
        // 创建自带几何体
        // if u get a gameobj ,u can get everything of it
        GameObject gameobj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        gameobj.name = "LittleCube";


        // find object that is active
        // 1. find single object
        // by name
        // this is not recommended,because it is slow
        GameObject obj2 = GameObject.Find("LittleCube");
        if(obj2 != null)
            print(obj2.name);

        // by tag
        // same as FindWithTag
        GameObject obj3 = GameObject.FindGameObjectWithTag("Player");


        // 得到某一个单个对象，目前有两种方式，1是public从外部面板拖入，2是通过API去找
        // 查找多个对象
        // To find many objects,u can only find by tag
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print(objs.Length);

        // Unity中的Object不是指万物之父System中的object
        // Unity中的object是命名空间在UnityEngine下的一个类
        // C#中的object是System下的一个类
        // 他们两个有区别

        // 它可以找到场景中挂载的某一个脚本对象
        // 效率低下
        Lesson4 o = GameObject.FindObjectOfType<Lesson4>();
        print(o.gameObject.name);


        // 实例化对象（克隆对象）方法
        // 根据一个GameObject对象，创建出一个和它一模一样的对象
        // GameObject也有这个方法，等效
        GameObject myObj = Instantiate(obj);

        // 删除对象的方法
        // GameObject.Destroy(myObj,5);
        // Distory方法不会马上移除对象，只是给对象加了一个移除标识，
        // 一般情况下他会在下一帧吧这个对象移除并从内存中删除，异步，可以降低卡顿几率
        // Destroy不仅可以删除对象，还可以删除脚本，
        // Destroy(this);

        // 如果没有特殊需求，一般都用上面这个方法
        // 下面这个方法可以立即删除对象
        // DestroyImmediate(myObj);

        // 如果是继承MonoBehaviour的类,不用写GameObject
        // 过场景不移除
        // 默认情况在切换场景时，场景中的对象都会被销毁
        // 但是如果这个对象是DontDestroyOnLoad的对象，那么在切换场景时，这个对象不会被销毁
        GameObject.DontDestroyOnLoad(myObj);
        #endregion

        #region 知识点3 GameObject的成员方法
        // 创建一个空对象
        GameObject obj5 = new GameObject("空对象");
        print(obj5.name);
        GameObject obj6 = new GameObject("带有脚本的对象", typeof(Lesson2));

        // 为对象添加脚本
        // 继承MonoBehaviour的类是不能直接new出来的
        // 只能通过AddComponent方法添加
        Lesson1 les1 = obj6.AddComponent<Lesson1>();
        // 可以接收返回值，然后对这个脚本中的变量进行赋值等

        // 标签比较
        this.gameObject.CompareTag("Player");

        obj6.SetActive(false); // 设置对象是否激活


        // 次要的成员方法，了解即可
        // 通过广播或者发送消息的方式来调用对象上的方法

        // 1.通知自己执行什么行为
        // 命令自己去执行TestFunc,会在自己身上挂载的所有脚本去找这个名字的方法
        this.gameObject.SendMessage("TestFunc", "2");


        // 广播行为，让自己和自己的子对象执行
        this.BroadcastMessage("TestFunc", "3");



        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void TestFunc(string str)
    {
        print("TestFunc" + str);
    }
}
