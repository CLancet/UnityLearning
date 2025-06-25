using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #region 触发器碰撞检测函数

    // 触发开始的时候调用
    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag.Equals("Obstacle"))
        {
            // 如果碰撞的对象是地面（plane），则销毁子弹
            Debug.Log("子弹碰到地面，销毁子弹: " + other.gameObject.name);
            Destroy(this.gameObject);
            return;
        }

    }
    #endregion
}
