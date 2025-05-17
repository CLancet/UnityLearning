using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region Transform
        #endregion

        #region ֪ʶ��һ Vector3
        // Vector3��һ����ά���� ��һ���ṹ��
        Vector3 vector3 = new Vector3(1, 2, 3);// �вι��� ���ֻ��һ����������������������Ĭ�ϵ���0
        Vector3 vector3_1 = new Vector3(); // �޲ι���
        // ��ֵ
        vector3_1.x = 1;
        vector3_1.y = 2;
        vector3_1.z = 3;
        // vector��������
        // �ӷ�
        Vector3 vector3_2 = vector3 + vector3_1;
        // ����
        Vector3 vector3_3 = vector3 - vector3_1;
        // �˷�
        Vector3 vector3_4 = vector3 * 3.0f;
        // ����
        Vector3 vector3_5 = vector3 / 3.0f;

        // ���õ���������̬���ԣ�
        print(Vector3.zero);
        print(Vector3.right);//100
        print(Vector3.left);//-100
        print(Vector3.up);//010
        print(Vector3.down);//0-10
        print(Vector3.forward);//001 �泯��
        print(Vector3.back);//00-1 ������

        // ���÷��� ����������֮��ľ���
        float distance = Vector3.Distance(vector3, vector3_1); // ����������֮��ľ���
        #endregion


        #region ֪ʶ��� λ��
        // �����������ϵ
        print(this.gameObject.transform.position);// this.transform.position
        // ��Ը���������ϵ
        print(this.gameObject.transform.localPosition);// this.transform.localPosition

        //λ�õĸ�ֵ����ֱ�Ӹı�xyz,ֻ������ı�
        this.transform.position = new Vector3(1, 2, 3);

        // ����ĸ�������
        print(this.gameObject.transform.forward); // ǰ�� ����������ϵ��ʾ��ǰ����ĳ���
        print(this.gameObject.transform.right); // �ҷ� ����������ϵ��ʾ��ǰ����ĳ���
        print(this.gameObject.transform.up); // �Ϸ� ����������ϵ��ʾ��ǰ����ĳ���


        #endregion




    }

    // Update is called once per frame
    void Update()
    {
        #region ֪ʶ���� λ�� this.transform.xxword�õ��ķ����ǻ�����������ϵ��

        // �����λ�� ����*�ٶ�*ʱ��
        //��ʽһ �Լ��ִ� ��ǰ��λ�ü���Ҫ�ƶ��ľ���
        //this.transform.position += this.transform.forward * 3.0f * Time.deltaTime;
        // this.transform.position += this.transform.forward * 3.0f * Time.deltaTime + this.transform.right * 3.0f * Time.deltaTime;
        // ��ʽ�� ʹ��API,һ��ʹ��API���ƶ�����
        // ����һ ����ʾλ�ƶ���
        // ������ ����ʾ�������ϵ,Ĭ�ϸò������Լ�������ϵ
        // �������������ϵ���Լ����泯��ȥ�ƶ�
        // this.transform.Translate(this.transform.forward * 3.0f * Time.deltaTime, Space.World);
        //Ч����ͬ
        this.transform.Translate(Vector3.forward*3*Time.deltaTime,Space.Self);

        #endregion

        //�ܽ�
        // Vector3
        // ������������þ�̬���ԣ��������ķ�����λ�ã���������ϵ�;ֲ�����ϵ
        // ���ܵ����޸�xyz
        // λ�Ƶļ���
    }
}
