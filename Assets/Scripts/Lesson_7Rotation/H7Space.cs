using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class H7Space : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "Sun")
        {
            // this.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
        }
        else if (this.gameObject.name == "Earth")
        {
            // �õ���Χ����̫��ת��
            this.transform.RotateAround(GameObject.Find("Sun").transform.position, Vector3.up, 10 * Time.deltaTime);
            // �õ�����ת
            this.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
        }
        else if (this.gameObject.name == "Moon")
        {
            // ������Χ���ŵ���ת��
            this.transform.RotateAround(GameObject.Find("Earth").transform.position, Vector3.up, 10 * Time.deltaTime);
            // ��������ת
            this.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
        }
    }
}
