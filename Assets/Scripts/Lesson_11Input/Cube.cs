using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int hitCount = 0; // ���ڼ�¼�����屻��Ĵ���

    private void OnTriggerEnter(Collider other)
    {
        // ��⵽�ӵ���ײʱ�������屻�������1
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("�����屻��һ��: " + this.gameObject.name);
            // ����������������屻����߼����������ӷ�����
            hitCount++;
            if(hitCount >= 3) // ���������屻��3�κ�����
            {
                Debug.Log("�����屻��3�Σ�����������: " + this.gameObject.name);
                Destroy(this.gameObject); // ����������
            }
            Destroy(other.gameObject); // �����ӵ�
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
