using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ ��������ת��������
        print(Vector3.forward);
        // ��������ϵ�ĵ�ת��Ϊ��������ϵ�ĵ�

        // 1.�ܵ�����Ӱ��
        // �������scaleΪ0.5ʱ����������ϵ�µ�һ���ڱ�������ϵ��������
        // �����ڣ�1,0,1������������ϵ�µģ�0,0,1������ڱ��ص�����
        // ��������scaleΪ0.5
        // position after trans(-1.41, 0.00, -1.41)
        // ��������scaleΪ1
        // position after trans(-0.71, 0.00, -0.71)
        print("position after trans"+this.transform.InverseTransformPoint(Vector3.forward));



        // 2.��������Ӱ��


        // ��������ϵ�ķ��� ת��Ϊ����ڱ�������ϵ�ķ���
        // 1.������Ӱ��
        // ��������λ�ã�ƽ�Ʒ�����������ʼ�㣬�ŵ���������ϵ��ԭ��
        // �����scale��0.5
        // ԭ����������0,0,1��
        // ����λ�ã�1,0,1��
        // ����������ϵ�µķ�������(-1.41, 0.00, 1.41)
        // �յ�scaleӰ�죬ԭ������������Ϊ1���������ű���Ϊ0.5�����ź󳤶�Ϊ2
        print("direction after transform affected by scale" + this.transform.InverseTransformVector(Vector3.forward));


        // 2.��������Ӱ��
        // ��������λ�ã�ƽ�Ʒ�����������ʼ�㣬�ŵ���������ϵ��ԭ��
        // ���������scale�Ƕ���
        // ԭ����������0,0,1��
        // ����λ�ã�1,0,1��
        // ����������ϵ�µķ������� direction after transform(-0.71, 0.00, 0.71)
        print("direction after transform" + this.transform.InverseTransformDirection(Vector3.forward));

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
