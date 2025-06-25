using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H11 : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        this.transform.position = new Vector3(0, 0, 0);
        this.transform.eulerAngles = new Vector3(0, -90, 0);
        // 锁定鼠标在屏幕中心

    }

    // Update is called once per frame
    void Update()
    {
        // 检测键盘输入
        float vertical = Input.GetAxis("Vertical");
        if (vertical>0)
        {
            this.transform.Translate(Vector3.right * Time.deltaTime*vertical*10);
        }
        else if (vertical<0)
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * -vertical * 10);
        }
        
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal>0) {
            this.transform.Rotate(Vector3.up * Time.deltaTime * horizontal * 10);

        }
        else if (horizontal < 0)
        {
            this.transform.Rotate(Vector3.up * Time.deltaTime * horizontal * 10);
        }
        Transform sphere = this.transform.GetChild(1);
        // 检测鼠标转向

         float mouseX = Input.GetAxis("Mouse X");
         // float mouseY = Input.GetAxis("Mouse Y");
         sphere.Rotate(Vector3.up * Time.deltaTime * mouseX * 100,Space.World);
         // sphere.Rotate(Vector3.forward * Time.deltaTime * mouseY * 100, Space.World);


        //// 获取鼠标滚轮
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0) {
            sphere.Rotate(Vector3.forward*Time.deltaTime * scroll * 1000, Space.Self);

        }
        else if (scroll < 0)
        {
            sphere.Rotate(Vector3.forward * Time.deltaTime * scroll * 1000, Space.Self);
        }



    }
}
