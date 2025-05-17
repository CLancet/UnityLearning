using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H6 : MonoBehaviour
{

    public int layerCount = 1; // 金字塔的层数默认为4层
    // Start is called before the first frame update
    void Start()
    {
        // 创建一个n层的金字塔
        // 第一层一个，第二层四个，第三层九个，第四层十六个
        // 1.获取脚本挂载的物体
        GameObject pyramidParent = this.gameObject; // 获取脚本挂载的物体
        // 2.创建一个立方体作为金字塔的基础
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(1, 1, 1); // 设置立方体的大小
        cube.transform.position = new Vector3(0, 0, 0); // 设置立方体的位置
        cube.name = "Layer1"; // 设置立方体的名称
        cube.transform.parent = pyramidParent.transform; // 将立方体设置为金字塔的子物体
        // 3.创建金字塔的每一层
        //cube.transform.localPosition = new Vector3(0, 0, 0); // 设置立方体的位置
        for (int i = 2; i <= layerCount; i++)
        {
            // 创建一层金字塔
            GameObject layer = new GameObject("Layer" + i);
            layer.transform.parent = pyramidParent.transform; // 将层设置为金字塔的子物体
            layer.transform.localPosition = new Vector3(0, i-1, 0); // 设置层的位置
            // 先计算出所在的Z轴位置
            // z轴最高处位于0.5f*(i-1)的地方
            float zPos = 0.5f * (i - 1);
            float xPos = 0.5f * (i - 1); // x轴位置
            // 创建每一层的立方体
            for (int j = 0; j < i; j++)
            {
                for (int k = 0; k < i; k++)
                {
                    GameObject cubeInstance = Instantiate(cube); // 实例化立方体
                    cubeInstance.transform.parent = layer.transform; // 将立方体设置为层的子物体
                    float xOffset = xPos - k;// 计算x轴偏移量
                    float zOffset = zPos - j; // 计算z轴偏移量
                    cubeInstance.transform.localPosition = new Vector3(xOffset, 0, zOffset); // 设置立方体的位置，相对于这层的位置
                }
            }
            
        }
        // 把金字塔转为正的
        pyramidParent.transform.rotation = Quaternion.Euler(0, 0, 180); // 设置金字塔的旋转
        // 将金字塔的最底部放在y=0的位置
        pyramidParent.transform.position = new Vector3(0, layerCount, 0); // 设置金字塔的位置

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
