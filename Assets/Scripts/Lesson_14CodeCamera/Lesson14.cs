using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ��ȡ�����
        // ���������ȡ
        // Ҫ�󳡾��е��������tag������"MainCamera"
        Camera cam = Camera.main;
        // ��ȡ��ǰ�����������
        int cameraCount = Camera.allCamerasCount;
        // �õ����������
        Camera[] cameras = Camera.allCameras;


        //2.��Ⱦ���ί��
        // ������޳�ǰ�����ί�к���
        Camera.onPreCull += (c)=>
        {
        };

        // �������Ⱦǰ�����ί�к���
        Camera.onPreRender += (c) =>
        {
        };
        // �������Ⱦ�����ί�к���
        Camera.onPostRender += (c) =>
        {
            // ���������Ⱦ��ִ�еĴ���
            // ���磺����һЩUIԪ�ػ���Ч
        };

        #region ֪ʶ��2 ��Ҫ��Ա
        //�����ϵĲ���������ͨ������������
        //2.��������ת��Ļ����
        //������Ѫ�����
        //����ǹ����������ϵĽű�����ȡ�������������Ȼ��תΪ��Ļ���꣬z���ʾ���3D��������������Զ��
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position); 
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //��Ļ����ת��������
        // Ҫ�ı�z�ᣬ��Ϊ���z�᲻�ģ���zĬ��Ϊ0��ת������������ʱ���������������
        // �������Ϊ�ӿ��ཻ�ĵ�
        // ����ı���z�ᣬ��ôת����ȥ�ĵ��������������ǰ�����ٵĵ�λ�ĺ�����ϵ����������
    }
}
