using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lseeon9 : MonoBehaviour
{
    public Transform son;// ������Ӷ���

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ ��ȡ�����ø�����
        // ��ȡ������
        print(this.transform.parent.name);
        // ���ø�����
        this.transform.parent = null;
        // ������
        Transform parent2 = GameObject.Find("Father2").transform;
        if (parent2 != null)
        {
            this.transform.parent = parent2;
        }

        // ͨ��API�����и��ӹ�ϵ������
        // 1.���ø�����
        this.transform.SetParent(parent2);// SetParent���������صĵڶ���������һ��bool

        this.transform.SetParent(parent2,true);// �ڶ����������������Ƿ������������λ�ýǶ�������Ϣ
                                               // �����true����ᱣ�������������Ϣ��ֻ�Ǹ��������˱仯��
                                               // �����false����ᱣ�������������Ϣ��ԭ�����������ı仯������������ڸ�����ı仯��
        #endregion

        #region ֪ʶ��� ȡ���Ӷ���
        this.transform.DetachChildren();// ȡ���Լ��������Ӷ���
        #endregion


        #region ֪ʶ��� ���ӵĲ���
        if (son.IsChildOf(this.transform)){
            print(this.transform.parent.name);
        }

        // �õ��Լ���Ϊ���ӵı��
        print(son.GetSiblingIndex());// ����ǵõ��Լ���Ϊ���ӵı��
                                     // 
                                     //���Լ�����Ϊ��һ������
        son.SetSiblingIndex(0);// ����������Լ���Ϊ���ӵı��
        son.SetAsFirstSibling();// ����������Լ���Ϊ��һ������
        son.SetAsLastSibling();
        #endregion


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
