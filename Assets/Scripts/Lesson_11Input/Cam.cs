using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform target;     // ���� Tank �� Transform
    public Vector3 offset = new Vector3(-5, 5, 0); // ��������� Tank �����λ��

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(1))
        //{
            
        //}
    }


    void LateUpdate()
    {
        if (target == null) return;

        // �����������λ��
        // transform.position = target.position + offset;
        // this.transform.RotateAround(target.position, Vector3.up, 100 * Time.deltaTime);


        // ʼ�ճ��� Tank
        transform.LookAt(target);
        // this.transform.rotation = Quaternion.Euler(30, 90, 0);


    }
}
