using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ��ȡ��ǰ��Ļ�ֱ���
        Resolution r = Screen.currentResolution;
        print("��ǰ��Ļ�Ŀ�"+r.width+"��ǰ��Ļ�ĸ�"+r.height);// �豸���ڵĴ�С

        print(Screen.width);//��ǰgame���ڵĿ��,unity�е�game���ڿ����Լ��ģ���д����Ҫ�ÿ��ʱʹ�����

        // ��Ļ����ģʽ
        Screen.sleepTimeout = SleepTimeout.NeverSleep; // ��������



        // ����ȫ��ģʽ
        Screen.fullScreen = true;
        // ����ģʽ
        // ��ռȫ��
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;


        // ���÷ֱ���
        // �ƶ��豸��ʹ��
        // Screen.SetResolution(1, 1,false);// �������������Ƿ�ȫ��

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
