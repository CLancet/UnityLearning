using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int hitCount = 0; // 用于记录立方体被打的次数

    private void OnTriggerEnter(Collider other)
    {
        // 检测到子弹碰撞时，立方体被打次数加1
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("立方体被打一次: " + this.gameObject.name);
            // 这里可以增加立方体被打的逻辑，比如增加分数等
            hitCount++;
            if(hitCount >= 3) // 假设立方体被打3次后销毁
            {
                Debug.Log("立方体被打3次，销毁立方体: " + this.gameObject.name);
                Destroy(this.gameObject); // 销毁立方体
            }
            Destroy(other.gameObject); // 销毁子弹
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
