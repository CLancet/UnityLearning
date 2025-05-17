using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region 知识点一 时间缩放比例
        //// 时间停止
        //Time.timeScale = 0; // 暂停游戏
        //// 恢复正常
        //Time.timeScale = 1; // 恢复正常 默认等于1
        //// 2倍速
        //Time.timeScale = 2; // 2倍速
        //// 0.5倍速
        //Time.timeScale = 0.5f; // 0.5倍速
        #endregion

        #region 知识点一 帧间隔时间
        // 最近的一帧用了多长时间 单位是s

        // 帧间隔时间主要是用来计算物体的位移的
        // 根据需求选择参与计算的间隔时间，如果希望游戏暂停就不动的话，用deltaTime
        // 如果希望游戏暂停也能继续移动的话，就用unscaledDeltaTime
        // 收到scale影响的
        print("受scale影响的帧间隔时间"+Time.deltaTime);

        // 不受到scale影响的
        print("不受scale影响的帧间隔时间" + Time.unscaledDeltaTime);
        #endregion

        #region 知识点3 游戏开始到现在的时间
        // 受scale影响的
        print("游戏开始到现在的时间"+Time.time);
        // 不受scale影响的
        print("不受Scale影响的游戏开始到现在的时间" + Time.unscaledTime);
        #endregion


        #region 知识点五 帧数
        // 从开始到现在的帧数
        print("从开始到现在的帧数" + Time.frameCount);
        #endregion

        //总结 Time最常用的就是我们的
        //1.帧间隔时间 计算位移相关内容
        //2.时间缩放比例 用来暂定或者倍速
        //3.帧数
    }


    private void FixedUpdate()
    {
        #region 知识点4 物理引擎的时间
        // 受scale影响的
        print("物理引擎的时间" + Time.fixedDeltaTime);
        // 不受scale影响的
        print("不受scale影响的物理引擎的时间" + Time.fixedUnscaledDeltaTime);
        #endregion
    }
}
