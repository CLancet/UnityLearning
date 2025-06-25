using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_17Force : MonoBehaviour
{

    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ �����Դ�������ķ���
        // ��ȡ�������
        body = this.GetComponent<Rigidbody>();
        // �������
        // �������������
        // ���û����������һֱ�˶�
        body.AddForce(Vector3.forward * 1000);// ��������ϵ��z��������

        // �������������
        body.AddRelativeForce(Vector3.forward * 1000);// ��������ϵ��z��������

        // ���Ť����
        body.AddTorque(Vector3.up * 1000);// ��������ϵ��y��������

        // ֱ�Ӹı��ٶ�
        body.velocity = Vector3.forward * 10; // ��������ϵ��z��������

        // ģ�ⱬըЧ��
        // ���Ч������ȫ�ֵģ�����Ӱ���������壬ֻ��Ӱ�쵱ǰ����
        body.AddExplosionForce(1000, this.transform.position, 5f);
        #endregion

        #region ���ļ���ģʽ
        body.AddForce(Vector3.forward * 1000, ForceMode.Force); // ������
        body.AddForce(Vector3.forward * 1000, ForceMode.Acceleration); // �������ٶ�
        body.AddForce(Vector3.forward * 1000, ForceMode.Impulse); // ˲ʱ��
        body.AddForce(Vector3.forward * 1000, ForceMode.VelocityChange); // ˲ʱ�ٶȱ仯
                                                                         // ��������
                                                                         // Ft = mv
                                                                         // F = m * a
                                                                         // v = a * t  = F / m * t

        // ����F = ��0,0,10��
        // t = 0.02s(����֡��)

        // Acceleration
        // ������һ�������ļ��ٶȣ�����������mĬ��Ϊ1)
        // v = a * t = (0,0,10) * 0.02 = (0,0,0.2)

        // force
        // ������һ��������������������,m=2
        // v = a * t = (0,0,10) / 2 * 0.02 = (0,0,0.1)

        // Impulse
        // ������һ��˲ʱ������������������й�m=2������ʱ�䣬Ĭ��Ϊ1
        // v = a * t = (0,0,10) / 2 * 1 = (0,0,5)

        // VelocityChange
        // ������һ��˲ʱ���ٶȱ仯��������������޹�,��ʱ��Ҳ�޹�
        // v = a * t = (0,0,10) * 1 = (0,0,10)
        #endregion

        #region ֪ʶ���� ����
        // Constant Force
        #endregion

        #region ֪ʶ���� ��������
        // ��һ��ʱ����û���ܵ�����Ӱ�죬������Զ�����
        // ridbody.IsSleeping = true; // ���ø���Ϊ����״̬
        // ridbody.WakeUp(); // ���Ѹ���

        if(body.IsSleeping())
        {
            body.WakeUp(); // ���Ѹ���
        }
        else
        {
            Debug.Log("���崦�ڻ״̬");
        }
        #endregion

        #region �����������λ�Ƶķ���
        // 1. ��Update�иı�Transform��λ��
        // 2. ��Update��ʹ��Transform.Translate
        // 3. ͨ�������AddForce������ע��������ĸ�����ϵ
        // 4. ͨ�������velocity����
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
