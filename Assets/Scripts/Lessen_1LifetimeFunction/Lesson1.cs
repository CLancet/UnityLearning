using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // �������Լ��������󣩱�����ʱ���ã�������gameObject����ʱ������ܺ����
    // ���ƹ��캯���Ĵ��ڣ���һ������󴴽���ʱ�����
    private void Awake()
    {
        // Print message in Unity console
        // 1.û�м̳�MonoBehaviour
        //Debug.Log("123");
        //Debug.LogError("Error");
        //Debug.LogWarning("Warning");
        // 2.�̳�MonoBehaviour����һ���̵߳ķ���
        print("Awake");

    }

    //��������ʱ����ã�����������Inspector����ϣ���ѡ���������ĸ�ѡ��
    private void OnEnable()
    {
        print("OnEnable");
    }
    // Start is called before the first frame update
    // Ҳ�����ڳ�ʼ���ģ����������Awake��˵��Start�ǵȵ����еĶ��󶼴�������֮��Ż����
    void Start()
    {
        print("Start");
    }

    // �����Ҫ��������������ĸ���
    // FixedUpdateҲ��ÿ֡���õģ��������ǹ̶�ʱ�������õģ���������Ϸ֡
    // ����̶�ʱ�������Project Settings������
    private void FixedUpdate()
    {
        // ��������ĸ���
        print("FixedUpdate");
    }


    // Update is called once per frame
    // ��Ҫ���ڴ�����Ϸ�����߼����µĺ���
    void Update()
    {
        print("Update");
    }

    // ���������ÿ֡�����õĺ���
    // ��Ҫ���ڴ������������߼�
    // ��Update��LateUpdate֮�䣬Unity������һЩ�����������Ƕ�����صĸ���
    private void LateUpdate()
    {

        print("LateUpdate");
    }

    // ��������ǵ�����ʧ���ʱ����õ�
    // ���������ָInspector����ϣ�ȡ�����������ĸ�ѡ��
    private void OnDisable()
    {
        print("OnDisable");
    }

    // ��������ǵ��������ٵ�ʱ����õ�
    // ���������ָDestroy���������ã����߳����л���ʱ��
    private void OnDestroy()
    {
        print("OnDestroy");
    }
}


