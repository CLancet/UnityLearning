using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #region ��������ײ��⺯��

    // ������ʼ��ʱ�����
    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag.Equals("Obstacle"))
        {
            // �����ײ�Ķ����ǵ��棨plane�����������ӵ�
            Debug.Log("�ӵ��������棬�����ӵ�: " + other.gameObject.name);
            Destroy(this.gameObject);
            return;
        }

    }
    #endregion
}
