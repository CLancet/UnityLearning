using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{

    public Transform lookAtObj;
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ ����
        // 1.�������������ϵ����
        print(this.transform.lossyScale);
        // 2.����ڱ�������ϵ����
        print(this.transform.localScale);

        // ���Ų���ֻ��xyz��ֻ��һ��ģ��������������ϵ�����Ŵ�Сֻ�ܵõ����������ã�
        // ���� Ҫ�������Ŵ�Сֻ��ͨ��localScale������
        this.transform.localScale = new Vector3(3, 3, 3);

        // Unity��û�й������ŵ�API��ֻ���Լ�д
        // �����Ҫ���ŷ����仯��ֻ���Լ�д
        #endregion

        #region ֪ʶ��� ����
        // ��һ��������泯��һֱ������һ������
        this.transform.LookAt(GameObject.Find("Sun").transform);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale+=Vector3.one*Time.deltaTime;
    }
}
