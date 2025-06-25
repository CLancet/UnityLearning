using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region 知识点1 鼠标在屏幕的位置
        // 和输入相关的内容都在Input内
        // 获取鼠标在屏幕中的像素位置（左下角为原点）
        //Vector3 mouseScreenPos = Input.mousePosition;
        //Debug.Log("鼠标屏幕位置: " + mouseScreenPos);

        // 如果你想将其转为世界坐标（比如射线检测），可以用 Camera.main.ScreenToWorldPoint
        // 需要指定一个 z 值（距离摄像机的深度）
        //Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(new Vector3(mouseScreenPos.x, mouseScreenPos.y, 10f)); // 假设 z=10
        //Debug.Log("鼠标世界坐标: " + mouseWorldPos);
        #endregion

        #region 知识点2 检测鼠标输入
        // 鼠标左键按下
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("鼠标左键按下");
        }

        // 鼠标右键按下
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("鼠标右键按下");
        }

        // 鼠标中键按下
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("鼠标中键按下");
        }

        // 鼠标左键持续按住
        if (Input.GetMouseButton(0))
        {
            Debug.Log("鼠标左键持续按住中...");
        }

        // 鼠标左键抬起
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("鼠标左键抬起");
        }

        // 鼠标滚轮向上滚动
       print(Input.mouseScrollDelta);

        #endregion

        #region 知识点3 检测键盘输入

        // 两个重载
        // 1. Input.GetKey(KeyCode) - 检测按键是否按下 keycode是一种枚举类型
        // 2. Input.GetKet(string) - 检测按键是否按下 string是字符串类型 字符串类型的不能是大写，不然会报错
        // 按键按下（只触发一次）
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("按下了空格键");
        }

        // 按键持续按住（每帧都会触发）
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Debug.Log("W键持续按住中...");
        //}

        // 按键抬起
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("W键抬起");
        }

        // 检查组合键
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("按下了 Ctrl + S");
        }
        #endregion

        #region 知识点4 检测默认轴输入
        // 获取水平轴输入（A = -1, D = +1, 或者 左右方向键）
        float h = Input.GetAxis("Horizontal");
        // 获取垂直轴输入（W = +1, S = -1, 或者 上下方向键）
        float v = Input.GetAxis("Vertical");

        Debug.Log($"水平轴: {h}, 垂直轴: {v}");

        // 注意：GetAxis 是平滑的（逐渐变化），GetAxisRaw 是立即响应 -1/0/1
        float hRaw = Input.GetAxisRaw("Horizontal");
        float vRaw = Input.GetAxisRaw("Vertical");
        Debug.Log($"Raw水平轴: {hRaw}, Raw垂直轴: {vRaw}");

        //鼠标横向移动
        float mouseX = Input.GetAxis("Mouse X");
        print(mouseX);
        //鼠标纵向移动
        float mouseY = Input.GetAxis("Mouse Y");
        print(mouseY);
        #endregion

        #region 其他
        // 检测键盘的输入内容
        print(Input.inputString);

        // 又任意键按下
        if (Input.anyKeyDown)
        {
            Debug.Log("任意键按下");
        }
        // 有任意键长按
        if (Input.anyKey)
        {
            Debug.Log("任意键持续按住中...");
        }



        // 手柄输入
        // 某一个手柄键按下
        if (Input.GetButtonDown("Fire1"))
        //还有很多其他的按键，比如 Jump, Fire2, Fire3
        {
            Debug.Log("手柄按下了 Fire1");
        }

        // 移动设备触摸相关 了解即可
        if(Input.touchCount > 0)
        {

            Touch t1 = Input.touches[0];
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("触摸开始");
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("触摸移动");
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log("触摸结束");
            }
        }

        #endregion
    }
}
