using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0, 1, 0);

    }
    public float forwardSpeed = 10f;
    public float turnSpeed = 100f;
    public Transform turret; // 坦克炮塔
    public Transform cannon; // 坦克炮管
    public Transform bullet; // 坦克炮弹
    public GameObject bulletPrefab; // 坦克炮弹预制体

    // Update is called once per frame
    void Update()
    {
        #region 坦克移动操作部分代码
        float forward = Input.GetAxis("Vertical");
        this.transform.Translate(Vector3.forward*Time.deltaTime * forward * forwardSpeed);
        float turn = Input.GetAxis("Horizontal");
        this.transform.Rotate(Vector3.up * Time.deltaTime * turn * turnSpeed);

        // 检测鼠标转向
        float mouseX = Input.GetAxis("Mouse X");
        turret.Rotate(Vector3.forward * Time.deltaTime * -mouseX * 100, Space.Self);

        // 获取鼠标滚轮
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if(cannon.eulerAngles.x>30&&cannon.eulerAngles.x < 40)
        {
            cannon.eulerAngles = new Vector3(30, cannon.eulerAngles.y, cannon.eulerAngles.z);
        }
        else if (cannon.eulerAngles.x <= 330 && cannon.eulerAngles.x >= 320)
        {
            cannon.eulerAngles = new Vector3(330, cannon.eulerAngles.y, cannon.eulerAngles.z);
        }
        print(cannon.eulerAngles.x);
        if (scroll > 0 && cannon.eulerAngles.x <= 30)
        {
            cannon.Rotate(Vector3.right * Time.deltaTime * scroll * 100, Space.Self);
        }
        else if (scroll > 0 && cannon.eulerAngles.x <= 360&&cannon.eulerAngles.x>=330) {
            cannon.Rotate(Vector3.right * Time.deltaTime * scroll * 100, Space.Self);
        }
        else if (scroll < 0 && cannon.eulerAngles.x >= 330)
        {
            cannon.Rotate(Vector3.right * Time.deltaTime * scroll * 100, Space.Self);
        }
        else if (scroll < 0 && cannon.eulerAngles.x >= 0&&cannon.eulerAngles.x<=30)
        {
            cannon.Rotate(Vector3.right * Time.deltaTime * scroll * 100, Space.Self);
        }
        #endregion

        #region 坦克射击部分代码
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bulletFromTank = Instantiate(bulletPrefab, bullet.position,bullet.rotation);
            bulletFromTank.GetComponent<Rigidbody>().AddForce(bulletFromTank.transform.forward * 8000);
        }
        #endregion
    }
}
