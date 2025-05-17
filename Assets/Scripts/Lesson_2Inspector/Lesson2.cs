using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum E_TestEnum
{
    Normal,
    Player,
    Monster
}
[System.Serializable]
public struct MyStruct
{
    public int age;
    public string sex;
}
[System.Serializable]
public class MyClass
{
    public int i;
    public string str;
}

public class Lesson2 : MonoBehaviour
{
    private int i0;
    protected string str0;

    [SerializeField] // ǿ�����л��ֶ�����
    private int privateInt;
    [SerializeField]
    protected string str1;
    // Start is called before the first frame update

    public int publicInt = 10;

    [HideInInspector] // �����ڼ�����е��ֶ�
    public int hiddenInt = 20;


    #region ֪ʶ��5, �󲿷����Ͷ�������ʾ�༭
    public int[] array;
    public List<int> list;
    public E_TestEnum testEnum;
    // public GameObject gameObject;

    // �ֵ䲻����Inspector����ʾ
    // ���ǿ���ʹ��[System.Serializable]��������ʾ,�ֵ���ô������
    public Dictionary<string, int> dictionary;
    public MyStruct myStruct;
    public MyClass myClass;
    #endregion

    // ��������
    // [Header("ͷ��")]
    // ��������Unity Inspector����֯�ͷ������
    [Header("basic settings")]
    public int age;
    public bool sex;
    public int attact;

    [Space()]
    // ��ͣע��Tooltip
    [Tooltip("Avoid")]
    public int miss;


    // ������ֵ�ķ�Χ
    [Range(0, 100)]
    public float luck;


    // ������ʾ�ַ�����Ĭ�ϲ�д������ʾ3�У�д�������Ƕ�Ӧ��
    [Multiline(2)]
    public string multilineString;

    // ��������ʾ�ַ���,��С��ʾ3�У������ʾ10�У�����֮��ͻ���ֹ�����
    [TextArea(3, 5)]
    public string textAreaString;

    // Ϊ������ӿ�ݷ���
    [ContextMenuItem("ResetM", "ResetMoney")]
    public int money = 100;

    // Ϊ������ӿ�ݷ���
    private void ResetMoney()
    {
        money = 0;
    }

    // Ϊ����������Կ�����Inspector��ִ��,�������Ե�
    [ContextMenu("This is the TestFunc")]
    private void testFunc()
    {
        print("testFunc");
    }

    void Start()
    {
        print(privateInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
