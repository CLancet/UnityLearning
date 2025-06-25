using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_17Force : MonoBehaviour
{

    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 刚体自带添加力的方法
        // 获取刚体组件
        body = this.GetComponent<Rigidbody>();
        // 刚体加力
        // 相对于世界坐标
        // 如果没有阻力，会一直运动
        body.AddForce(Vector3.forward * 1000);// 世界坐标系的z轴正方向

        // 相对于物体坐标
        body.AddRelativeForce(Vector3.forward * 1000);// 物体坐标系的z轴正方向

        // 添加扭矩力
        body.AddTorque(Vector3.up * 1000);// 世界坐标系的y轴正方向

        // 直接改变速度
        body.velocity = Vector3.forward * 10; // 世界坐标系的z轴正方向

        // 模拟爆炸效果
        // 这个效果不是全局的，不会影响其他物体，只会影响当前物体
        body.AddExplosionForce(1000, this.transform.position, 5f);
        #endregion

        #region 力的几种模式
        body.AddForce(Vector3.forward * 1000, ForceMode.Force); // 持续力
        body.AddForce(Vector3.forward * 1000, ForceMode.Acceleration); // 持续加速度
        body.AddForce(Vector3.forward * 1000, ForceMode.Impulse); // 瞬时力
        body.AddForce(Vector3.forward * 1000, ForceMode.VelocityChange); // 瞬时速度变化
                                                                         // 动量定理
                                                                         // Ft = mv
                                                                         // F = m * a
                                                                         // v = a * t  = F / m * t

        // 假设F = （0,0,10）
        // t = 0.02s(物理帧率)

        // Acceleration
        // 给物体一个持续的加速度，忽略质量（m默认为1)
        // v = a * t = (0,0,10) * 0.02 = (0,0,0.2)

        // force
        // 给物体一个持续的力，考虑质量,m=2
        // v = a * t = (0,0,10) / 2 * 0.02 = (0,0,0.1)

        // Impulse
        // 给物体一个瞬时的力，与物体的质量有关m=2，忽略时间，默认为1
        // v = a * t = (0,0,10) / 2 * 1 = (0,0,5)

        // VelocityChange
        // 给物体一个瞬时的速度变化，与物体的质量无关,与时间也无关
        // v = a * t = (0,0,10) * 1 = (0,0,10)
        #endregion

        #region 知识点三 力场
        // Constant Force
        #endregion

        #region 知识点三 刚体休眠
        // 在一定时间内没有受到力的影响，刚体会自动休眠
        // ridbody.IsSleeping = true; // 设置刚体为休眠状态
        // ridbody.WakeUp(); // 唤醒刚体

        if(body.IsSleeping())
        {
            body.WakeUp(); // 唤醒刚体
        }
        else
        {
            Debug.Log("刚体处于活动状态");
        }
        #endregion

        #region 能让物体产生位移的方法
        // 1. 在Update中改变Transform的位置
        // 2. 在Update中使用Transform.Translate
        // 3. 通过刚体的AddForce方法，注意相对于哪个坐标系
        // 4. 通过刚体的velocity属性
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
