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
        // ������̹�˵���ת
        // ���ҵ�Ԥ��������ΪSphere��������
        //Transform sphere = this.transform.Find("Sphere");
        //// ��Sphere����Χ����Tank�����Y����ת
        //// ��ת���ٶ���10��ÿ��
        //if (sphere != null)
        //{
        head.Rotate(Vector3.up, headRotateSpeed * Time.deltaTime);
        // ͨ��ŷ���ǵõ��ĽǶȲ���õ���������Ȼ��������ʾ���Ǹ���������ͨ������õ��ĽǶ�����������Χ��0-360֮��
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
        // ��pkPos����Χ����Z����ת����������ת��
        // ��pkPos����Χ����Z������ת��������ת���ǶȲ�����15��
        //float angle = Mathf.Sin(Time.time) * 15f;
        //pkPos.localEulerAngles = new Vector3(pkPos.localEulerAngles.x, pkPos.localEulerAngles.y, angle);

        //}


        // ���������ڹ�����ת��
        // ���ҵ�Ԥ��������ΪCannon��������
        //Transform cannon = this.transform.Find("Rotation");
        //// ��Cannon����Χ����Tank�����Z����ת������ת��20�Ⱥ�����ת��20�ȣ�����ת��
        //// ��ת���ٶ���10��ÿ��
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
