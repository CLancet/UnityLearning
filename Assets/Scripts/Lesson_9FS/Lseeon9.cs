using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lseeon9 : MonoBehaviour
{
    public Transform son;// 这个是子对象

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 获取和设置父对象
        // 获取父对象
        print(this.transform.parent.name);
        // 设置父对象
        this.transform.parent = null;
        // 父对象
        Transform parent2 = GameObject.Find("Father2").transform;
        if (parent2 != null)
        {
            this.transform.parent = parent2;
        }

        // 通过API来进行父子关系的设置
        // 1.设置父对象
        this.transform.SetParent(parent2);// SetParent方法的重载的第二个参数是一个bool

        this.transform.SetParent(parent2,true);// 第二个参数的意义是是否保留世界坐标的位置角度缩放信息
                                               // 如果是true，则会保留世界坐标的信息（只是父对象发生了变化）
                                               // 如果是false，则会保留本地坐标的信息（原来相对于世界的变化，现在是相对于父对象的变化）
        #endregion

        #region 知识点二 取消子对象
        this.transform.DetachChildren();// 取消自己的所有子对象
        #endregion


        #region 知识点二 儿子的操作
        if (son.IsChildOf(this.transform)){
            print(this.transform.parent.name);
        }

        // 得到自己作为儿子的编号
        print(son.GetSiblingIndex());// 这个是得到自己作为儿子的编号
                                     // 
                                     //把自己设置为第一个儿子
        son.SetSiblingIndex(0);// 这个是设置自己作为儿子的编号
        son.SetAsFirstSibling();// 这个是设置自己作为第一个儿子
        son.SetAsLastSibling();
        #endregion


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
