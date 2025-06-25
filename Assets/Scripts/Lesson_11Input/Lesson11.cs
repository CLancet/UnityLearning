using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region ֪ʶ��1 �������Ļ��λ��
        // ��������ص����ݶ���Input��
        // ��ȡ�������Ļ�е�����λ�ã����½�Ϊԭ�㣩
        //Vector3 mouseScreenPos = Input.mousePosition;
        //Debug.Log("�����Ļλ��: " + mouseScreenPos);

        // ������뽫��תΪ�������꣨�������߼�⣩�������� Camera.main.ScreenToWorldPoint
        // ��Ҫָ��һ�� z ֵ���������������ȣ�
        //Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(new Vector3(mouseScreenPos.x, mouseScreenPos.y, 10f)); // ���� z=10
        //Debug.Log("�����������: " + mouseWorldPos);
        #endregion

        #region ֪ʶ��2 ����������
        // ����������
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("����������");
        }

        // ����Ҽ�����
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("����Ҽ�����");
        }

        // ����м�����
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("����м�����");
        }

        // ������������ס
        if (Input.GetMouseButton(0))
        {
            Debug.Log("������������ס��...");
        }

        // ������̧��
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("������̧��");
        }

        // ���������Ϲ���
       print(Input.mouseScrollDelta);

        #endregion

        #region ֪ʶ��3 ����������

        // ��������
        // 1. Input.GetKey(KeyCode) - ��ⰴ���Ƿ��� keycode��һ��ö������
        // 2. Input.GetKet(string) - ��ⰴ���Ƿ��� string���ַ������� �ַ������͵Ĳ����Ǵ�д����Ȼ�ᱨ��
        // �������£�ֻ����һ�Σ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("�����˿ո��");
        }

        // ����������ס��ÿ֡���ᴥ����
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Debug.Log("W��������ס��...");
        //}

        // ����̧��
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("W��̧��");
        }

        // �����ϼ�
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("������ Ctrl + S");
        }
        #endregion

        #region ֪ʶ��4 ���Ĭ��������
        // ��ȡˮƽ�����루A = -1, D = +1, ���� ���ҷ������
        float h = Input.GetAxis("Horizontal");
        // ��ȡ��ֱ�����루W = +1, S = -1, ���� ���·������
        float v = Input.GetAxis("Vertical");

        Debug.Log($"ˮƽ��: {h}, ��ֱ��: {v}");

        // ע�⣺GetAxis ��ƽ���ģ��𽥱仯����GetAxisRaw ��������Ӧ -1/0/1
        float hRaw = Input.GetAxisRaw("Horizontal");
        float vRaw = Input.GetAxisRaw("Vertical");
        Debug.Log($"Rawˮƽ��: {hRaw}, Raw��ֱ��: {vRaw}");

        //�������ƶ�
        float mouseX = Input.GetAxis("Mouse X");
        print(mouseX);
        //��������ƶ�
        float mouseY = Input.GetAxis("Mouse Y");
        print(mouseY);
        #endregion

        #region ����
        // �����̵���������
        print(Input.inputString);

        // �����������
        if (Input.anyKeyDown)
        {
            Debug.Log("���������");
        }
        // �����������
        if (Input.anyKey)
        {
            Debug.Log("�����������ס��...");
        }



        // �ֱ�����
        // ĳһ���ֱ�������
        if (Input.GetButtonDown("Fire1"))
        //���кܶ������İ��������� Jump, Fire2, Fire3
        {
            Debug.Log("�ֱ������� Fire1");
        }

        // �ƶ��豸������� �˽⼴��
        if(Input.touchCount > 0)
        {

            Touch t1 = Input.touches[0];
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("������ʼ");
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("�����ƶ�");
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log("��������");
            }
        }

        #endregion
    }
}
