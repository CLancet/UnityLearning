using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    #region ������ײ��⺯��
    // �������������ں���
    // ���������������巢����ײʱ����

    // Collision ���͵Ĳ��������������Լ��Ķ������Ϣ
    // ������ײ�Ķ�����ײ����Ϣ
    // ��ײ�������������GameObject
    // ��ײ�������������Transform
    // ��ײ�ĽӴ�����Ϣ�����������꣬���ߵȣ�collision.contacts;
    // 
    private void OnCollisionEnter(Collision collision)
    {
        // ��������ײʱ����
        Debug.Log("������ײ: " + collision.gameObject.name);
    }

    // ������������������ײʱ��������
    private void OnCollisionStay(Collision collision)
    {
        // ��������ײʱ����
        Debug.Log("������ײ: " + collision.gameObject.name);
    }
    // �������������������ʱ����
    private void OnCollisionExit(Collision collision)
    {
        // ������ʱ����
        Debug.Log("������ײ: " + collision.gameObject.name);
    }
    #endregion

    #region ��������ײ��⺯��
    // ������ʼ��ʱ�����
    private void OnTriggerEnter(Collider other)
    {
        // ����������ʼ����ʱ����
        Debug.Log("��������ʼ����: " + other.gameObject.name);
    }
    private void OnTriggerStay(Collider other)
    {
        // ����������������ʱ����
        Debug.Log("��������������: " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        // ��������ֹͣ����ʱ����
        Debug.Log("������ֹͣ����: " + other.gameObject.name);
    }
    #endregion

    #region ʲôʱ�����Ӧ����
    // ֻҪ���صĶ����ܺͱ�����������ײ���ߴ���
    #endregion

    #region ��ײ�����ʹ�������������д���麯��
    // ֻҪ���صĶ����ܺͱ�����������ײ���ߴ���
    // protected virtual void OnCollisionEnter(Collision collision)
    //{
        // ��������ײʱ����
        // Debug.Log("������ײ: " + collision.gameObject.name);
    //} 
#endregion

// Update is called once per frame
void Update()
    {

    }
}

