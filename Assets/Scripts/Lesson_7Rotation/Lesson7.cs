using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 角度相关
        // 相对于世界坐标系的角度
        print(this.transform.eulerAngles); // 输出物体的旋转角度
        // 相对于父对象的角度
        print(this.transform.localEulerAngles); // 输出物体的旋转角度

        // 设置角度和设置位置一样不能单个设置，要一起设置
        // 设置角度，如果希望改变的是面板上的角度，一定是LocalEulerAngles
        // this.transform.eulerAngles = new Vector3(0, 90, 0); // 设置物体的旋转角度


        // 为什么这里是Vector3而不是Quaternion，因为Quaternion是四元数，四元数是用来表示旋转的
        // 而Vector3是用来表示位置的，所以这里使用Vector3来表示旋转角度


      
    }

    // Update is called once per frame
    void Update()
    {
        #endregion

        #region 知识点二 旋转相关
        // 通过API设置旋转
        //// 自转
        //this.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0)); // 第二个参数不传的话默认是自己的坐标系

        //// 相对于某一个轴来转
        //this.transform.Rotate(Vector3.up,10 * Time.deltaTime);
        //// 反方向旋转
        //this.transform.Rotate(Vector3.up, -10 * Time.deltaTime);


        // 相对于某一个点来转
        this.transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime); // 这个点是世界坐标系的原点
        #endregion
    }
}
