using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    //׼��������¡�Ķ���
    // �����ǳ����еĶ���
    // ������Ԥ����
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��1 gameObject ��Ա����
        // ����
        print(this.gameObject.name);
        this.gameObject.name  = "С��"; // ����֮���ֻ���ԭ��������
        print(this.gameObject.name);

        //�Ƿ񼤻�
        print(this.gameObject.activeSelf);

        //�Ƿ��Ǿ�̬
        print(this.gameObject.isStatic);

        //layer
        print(this.gameObject.layer);

        // tag
        print(this.gameObject.tag);

        // transform
        //this.transform get transform by Mono(script equal to gameobject.transform)
        print(this.gameObject.transform.position);
        #endregion

        #region ֪ʶ��2 gameObject�еľ�̬����
        // �����Դ�������
        // if u get a gameobj ,u can get everything of it
        GameObject gameobj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        gameobj.name = "LittleCube";


        // find object that is active
        // 1. find single object
        // by name
        // this is not recommended,because it is slow
        GameObject obj2 = GameObject.Find("LittleCube");
        if(obj2 != null)
            print(obj2.name);

        // by tag
        // same as FindWithTag
        GameObject obj3 = GameObject.FindGameObjectWithTag("Player");


        // �õ�ĳһ����������Ŀǰ�����ַ�ʽ��1��public���ⲿ������룬2��ͨ��APIȥ��
        // ���Ҷ������
        // To find many objects,u can only find by tag
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print(objs.Length);

        // Unity�е�Object����ָ����֮��System�е�object
        // Unity�е�object�������ռ���UnityEngine�µ�һ����
        // C#�е�object��System�µ�һ����
        // ��������������

        // �������ҵ������й��ص�ĳһ���ű�����
        // Ч�ʵ���
        Lesson4 o = GameObject.FindObjectOfType<Lesson4>();
        print(o.gameObject.name);


        // ʵ�������󣨿�¡���󣩷���
        // ����һ��GameObject���󣬴�����һ������һģһ���Ķ���
        // GameObjectҲ�������������Ч
        GameObject myObj = Instantiate(obj);

        // ɾ������ķ���
        // GameObject.Destroy(myObj,5);
        // Distory�������������Ƴ�����ֻ�Ǹ��������һ���Ƴ���ʶ��
        // һ���������������һ֡����������Ƴ������ڴ���ɾ�����첽�����Խ��Ϳ��ټ���
        // Destroy��������ɾ�����󣬻�����ɾ���ű���
        // Destroy(this);

        // ���û����������һ�㶼�������������
        // �������������������ɾ������
        // DestroyImmediate(myObj);

        // ����Ǽ̳�MonoBehaviour����,����дGameObject
        // ���������Ƴ�
        // Ĭ��������л�����ʱ�������еĶ��󶼻ᱻ����
        // ����������������DontDestroyOnLoad�Ķ�����ô���л�����ʱ��������󲻻ᱻ����
        GameObject.DontDestroyOnLoad(myObj);
        #endregion

        #region ֪ʶ��3 GameObject�ĳ�Ա����
        // ����һ���ն���
        GameObject obj5 = new GameObject("�ն���");
        print(obj5.name);
        GameObject obj6 = new GameObject("���нű��Ķ���", typeof(Lesson2));

        // Ϊ������ӽű�
        // �̳�MonoBehaviour�����ǲ���ֱ��new������
        // ֻ��ͨ��AddComponent�������
        Lesson1 les1 = obj6.AddComponent<Lesson1>();
        // ���Խ��շ���ֵ��Ȼ�������ű��еı������и�ֵ��

        // ��ǩ�Ƚ�
        this.gameObject.CompareTag("Player");

        obj6.SetActive(false); // ���ö����Ƿ񼤻�


        // ��Ҫ�ĳ�Ա�������˽⼴��
        // ͨ���㲥���߷�����Ϣ�ķ�ʽ�����ö����ϵķ���

        // 1.֪ͨ�Լ�ִ��ʲô��Ϊ
        // �����Լ�ȥִ��TestFunc,�����Լ����Ϲ��ص����нű�ȥ��������ֵķ���
        this.gameObject.SendMessage("TestFunc", "2");


        // �㲥��Ϊ�����Լ����Լ����Ӷ���ִ��
        this.BroadcastMessage("TestFunc", "3");



        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void TestFunc(string str)
    {
        print("TestFunc" + str);
    }
}
