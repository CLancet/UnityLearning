using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform target; // Ŀ������
    public Vector3 offset  = new Vector3 (0,0,5); // �����Ŀ�������ƫ����
    private void LateUpdate()
    {
        this.transform.position = target.position + offset; // �������λ��ΪĿ������λ�ü���ƫ����
        this.transform.LookAt(target); // �����ʼ�ճ���Ŀ������
    }
}
