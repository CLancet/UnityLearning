using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region ֪ʶ��һ ʱ�����ű���
        //// ʱ��ֹͣ
        //Time.timeScale = 0; // ��ͣ��Ϸ
        //// �ָ�����
        //Time.timeScale = 1; // �ָ����� Ĭ�ϵ���1
        //// 2����
        //Time.timeScale = 2; // 2����
        //// 0.5����
        //Time.timeScale = 0.5f; // 0.5����
        #endregion

        #region ֪ʶ��һ ֡���ʱ��
        // �����һ֡���˶೤ʱ�� ��λ��s

        // ֡���ʱ����Ҫ���������������λ�Ƶ�
        // ��������ѡ��������ļ��ʱ�䣬���ϣ����Ϸ��ͣ�Ͳ����Ļ�����deltaTime
        // ���ϣ����Ϸ��ͣҲ�ܼ����ƶ��Ļ�������unscaledDeltaTime
        // �յ�scaleӰ���
        print("��scaleӰ���֡���ʱ��"+Time.deltaTime);

        // ���ܵ�scaleӰ���
        print("����scaleӰ���֡���ʱ��" + Time.unscaledDeltaTime);
        #endregion

        #region ֪ʶ��3 ��Ϸ��ʼ�����ڵ�ʱ��
        // ��scaleӰ���
        print("��Ϸ��ʼ�����ڵ�ʱ��"+Time.time);
        // ����scaleӰ���
        print("����ScaleӰ�����Ϸ��ʼ�����ڵ�ʱ��" + Time.unscaledTime);
        #endregion


        #region ֪ʶ���� ֡��
        // �ӿ�ʼ�����ڵ�֡��
        print("�ӿ�ʼ�����ڵ�֡��" + Time.frameCount);
        #endregion

        //�ܽ� Time��õľ������ǵ�
        //1.֡���ʱ�� ����λ���������
        //2.ʱ�����ű��� �����ݶ����߱���
        //3.֡��
    }


    private void FixedUpdate()
    {
        #region ֪ʶ��4 ���������ʱ��
        // ��scaleӰ���
        print("���������ʱ��" + Time.fixedDeltaTime);
        // ����scaleӰ���
        print("����scaleӰ������������ʱ��" + Time.fixedUnscaledDeltaTime);
        #endregion
    }
}
