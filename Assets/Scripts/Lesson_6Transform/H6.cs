using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H6 : MonoBehaviour
{

    public int layerCount = 1; // �������Ĳ���Ĭ��Ϊ4��
    // Start is called before the first frame update
    void Start()
    {
        // ����һ��n��Ľ�����
        // ��һ��һ�����ڶ����ĸ���������Ÿ������Ĳ�ʮ����
        // 1.��ȡ�ű����ص�����
        GameObject pyramidParent = this.gameObject; // ��ȡ�ű����ص�����
        // 2.����һ����������Ϊ�������Ļ���
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(1, 1, 1); // ����������Ĵ�С
        cube.transform.position = new Vector3(0, 0, 0); // �����������λ��
        cube.name = "Layer1"; // ���������������
        cube.transform.parent = pyramidParent.transform; // ������������Ϊ��������������
        // 3.������������ÿһ��
        //cube.transform.localPosition = new Vector3(0, 0, 0); // �����������λ��
        for (int i = 2; i <= layerCount; i++)
        {
            // ����һ�������
            GameObject layer = new GameObject("Layer" + i);
            layer.transform.parent = pyramidParent.transform; // ��������Ϊ��������������
            layer.transform.localPosition = new Vector3(0, i-1, 0); // ���ò��λ��
            // �ȼ�������ڵ�Z��λ��
            // z����ߴ�λ��0.5f*(i-1)�ĵط�
            float zPos = 0.5f * (i - 1);
            float xPos = 0.5f * (i - 1); // x��λ��
            // ����ÿһ���������
            for (int j = 0; j < i; j++)
            {
                for (int k = 0; k < i; k++)
                {
                    GameObject cubeInstance = Instantiate(cube); // ʵ����������
                    cubeInstance.transform.parent = layer.transform; // ������������Ϊ���������
                    float xOffset = xPos - k;// ����x��ƫ����
                    float zOffset = zPos - j; // ����z��ƫ����
                    cubeInstance.transform.localPosition = new Vector3(xOffset, 0, zOffset); // �����������λ�ã����������λ��
                }
            }
            
        }
        // �ѽ�����תΪ����
        pyramidParent.transform.rotation = Quaternion.Euler(0, 0, 180); // ���ý���������ת
        // ������������ײ�����y=0��λ��
        pyramidParent.transform.position = new Vector3(0, layerCount, 0); // ���ý�������λ��

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
