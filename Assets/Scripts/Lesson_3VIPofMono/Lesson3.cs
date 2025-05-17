using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{

    public Lesson3 OtherLesson3;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点1 重要成员
        // 1.获取依附的GameObject
        print(gameObject.name); 
        // 2.获取依附的gameObject的Transform
        print(transform.position);
        print(transform.eulerAngles);
        print(this.transform.localScale);
        // 3.获取脚本是否激活
        // this.enabled = false;//禁用脚本
        // this.enabled = true;//启用脚本
        print(OtherLesson3.gameObject.name);
        #endregion


        #region 知识点2 重要方法
        // 获取依附对象上挂载的其他脚本
        // 1.得到自己挂载的脚本
        // 如果获取失败，默认值为null
        Lesson3Test t = this.GetComponent("Lesson3Test") as Lesson3Test; // 根据脚本名获取
        print(t);

        t = this.GetComponent(typeof(Lesson3Test)) as Lesson3Test; // 根据脚本类型获取
        print(t);

        t = this.GetComponent<Lesson3Test>(); // 根据泛型获取
        print(t);
        // 只要能获取到场景中的其他脚本，就能得到依附其所有对象信息


        // 2.获取自己挂载的多个脚本
        Lesson3Test[] tests = this.GetComponents<Lesson3Test>();
        print(tests.Length);
        List<Lesson3Test> testList = new List<Lesson3Test>();
        this.GetComponents<Lesson3Test>(testList);



        // 3.得到子对象上挂载的脚本，他默认也会找自己身上是否挂载该脚本
        this.GetComponentInChildren<Lesson3Test>();// 重载如果传入true,则失活的脚本也会被获取


        // 4.得到子对象上挂载的多个脚本，他默认也会找自己身上是否挂载该脚本
        this.GetComponentsInChildren<Lesson3Test>(true);// 重载如果传入true,则失活的脚本也会被获取
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
