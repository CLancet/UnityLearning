using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ �Ƕ����
        // �������������ϵ�ĽǶ�
        print(this.transform.eulerAngles); // ����������ת�Ƕ�
        // ����ڸ�����ĽǶ�
        print(this.transform.localEulerAngles); // ����������ת�Ƕ�

        // ���ýǶȺ�����λ��һ�����ܵ������ã�Ҫһ������
        // ���ýǶȣ����ϣ���ı��������ϵĽǶȣ�һ����LocalEulerAngles
        // this.transform.eulerAngles = new Vector3(0, 90, 0); // �����������ת�Ƕ�


        // Ϊʲô������Vector3������Quaternion����ΪQuaternion����Ԫ������Ԫ����������ʾ��ת��
        // ��Vector3��������ʾλ�õģ���������ʹ��Vector3����ʾ��ת�Ƕ�


      
    }

    // Update is called once per frame
    void Update()
    {
        #endregion

        #region ֪ʶ��� ��ת���
        // ͨ��API������ת
        //// ��ת
        //this.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0)); // �ڶ������������Ļ�Ĭ�����Լ�������ϵ

        //// �����ĳһ������ת
        //this.transform.Rotate(Vector3.up,10 * Time.deltaTime);
        //// ��������ת
        //this.transform.Rotate(Vector3.up, -10 * Time.deltaTime);


        // �����ĳһ������ת
        this.transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime); // ���������������ϵ��ԭ��
        #endregion
    }
}
