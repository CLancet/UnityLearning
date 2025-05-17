using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{

    public Transform lookAtObj;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 缩放
        // 1.相对于世界坐标系缩放
        print(this.transform.lossyScale);
        // 2.相对于本地坐标系缩放
        print(this.transform.localScale);

        // 缩放不能只改xyz，只能一起改（相对于世界坐标系的缩放大小只能得到，不能设置）
        // 所以 要更改缩放大小只能通过localScale来设置
        this.transform.localScale = new Vector3(3, 3, 3);

        // Unity中没有关于缩放的API，只能自己写
        // 如果想要缩放发生变化，只能自己写
        #endregion

        #region 知识点二 看向
        // 让一个对象的面朝向一直看向另一个对象
        this.transform.LookAt(GameObject.Find("Sun").transform);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale+=Vector3.one*Time.deltaTime;
    }
}
