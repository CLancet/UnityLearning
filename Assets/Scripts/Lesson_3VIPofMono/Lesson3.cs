using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{

    public Lesson3 OtherLesson3;
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��1 ��Ҫ��Ա
        // 1.��ȡ������GameObject
        print(gameObject.name); 
        // 2.��ȡ������gameObject��Transform
        print(transform.position);
        print(transform.eulerAngles);
        print(this.transform.localScale);
        // 3.��ȡ�ű��Ƿ񼤻�
        // this.enabled = false;//���ýű�
        // this.enabled = true;//���ýű�
        print(OtherLesson3.gameObject.name);
        #endregion


        #region ֪ʶ��2 ��Ҫ����
        // ��ȡ���������Ϲ��ص������ű�
        // 1.�õ��Լ����صĽű�
        // �����ȡʧ�ܣ�Ĭ��ֵΪnull
        Lesson3Test t = this.GetComponent("Lesson3Test") as Lesson3Test; // ���ݽű�����ȡ
        print(t);

        t = this.GetComponent(typeof(Lesson3Test)) as Lesson3Test; // ���ݽű����ͻ�ȡ
        print(t);

        t = this.GetComponent<Lesson3Test>(); // ���ݷ��ͻ�ȡ
        print(t);
        // ֻҪ�ܻ�ȡ�������е������ű������ܵõ����������ж�����Ϣ


        // 2.��ȡ�Լ����صĶ���ű�
        Lesson3Test[] tests = this.GetComponents<Lesson3Test>();
        print(tests.Length);
        List<Lesson3Test> testList = new List<Lesson3Test>();
        this.GetComponents<Lesson3Test>(testList);



        // 3.�õ��Ӷ����Ϲ��صĽű�����Ĭ��Ҳ�����Լ������Ƿ���ظýű�
        this.GetComponentInChildren<Lesson3Test>();// �����������true,��ʧ��Ľű�Ҳ�ᱻ��ȡ


        // 4.�õ��Ӷ����Ϲ��صĶ���ű�����Ĭ��Ҳ�����Լ������Ƿ���ظýű�
        this.GetComponentsInChildren<Lesson3Test>(true);// �����������true,��ʧ��Ľű�Ҳ�ᱻ��ȡ
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
