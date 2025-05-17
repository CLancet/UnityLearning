using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H7 : MonoBehaviour
{
    public float rotateSpeed = 10;
    public float headRotateSpeed = 10;
    public float cannonRotateSpeed = 20;
    public Transform head;
    public Transform pkPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 做关于坦克的旋转
        // 先找到预设体中名为Sphere的子物体
        //Transform sphere = this.transform.Find("Sphere");
        //// 让Sphere物体围绕着Tank物体的Y轴旋转
        //// 旋转的速度是10度每秒
        //if (sphere != null)
        //{
        head.Rotate(Vector3.up, headRotateSpeed * Time.deltaTime);
        // 通过欧拉角得到的角度不会得到负数，虽然界面上显示的是负数，但是通过代码得到的角度是正数，范围在0-360之间
        if (!(head.localEulerAngles.y <= 360 && head.localEulerAngles.y >= 315)
            && head.localEulerAngles.y>=45 && headRotateSpeed>0)
        {
            headRotateSpeed = -headRotateSpeed;
        }
        else if(!(head.localEulerAngles.y<=45&& head.localEulerAngles.y>=0)
            &&head.localEulerAngles.y <= 315 && headRotateSpeed<0)
        {
            headRotateSpeed = -headRotateSpeed;
        }
        // 让pkPos物体围绕着Z轴旋转，上下来回转动
        // 让pkPos物体围绕着Z轴来回转动，上下转动角度不超过15度
        //float angle = Mathf.Sin(Time.time) * 15f;
        //pkPos.localEulerAngles = new Vector3(pkPos.localEulerAngles.x, pkPos.localEulerAngles.y, angle);

        //}


        // 接下来是炮管上下转动
        // 先找到预设体中名为Cannon的子物体
        //Transform cannon = this.transform.Find("Rotation");
        //// 让Cannon物体围绕着Tank物体的Z轴旋转，往上转动20度后往下转动20度，来回转动
        //// 旋转的速度是10度每秒
        //if (cannon != null)
        //{
        //    print(cannon.localEulerAngles);
        //    // cannon.Rotate(Vector3.forward, 10 * Time.deltaTime);
        //    // cannon.Rotate(Vector3.back, 10 * Time.deltaTime);
        //    // cannon.Rotate(Vector3.right, 10 * Time.deltaTime);
        //    // cannon.Rotate(Vector3.left, 10 * Time.deltaTime);
        //    cannon.Rotate(Vector3.forward,  20 * Time.deltaTime);
        //}

    }
}
