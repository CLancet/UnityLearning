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

    [SerializeField] // 强制序列化字段特性
    private int privateInt;
    [SerializeField]
    protected string str1;
    // Start is called before the first frame update

    public int publicInt = 10;

    [HideInInspector] // 隐藏在检查器中的字段
    public int hiddenInt = 20;


    #region 知识点5, 大部分类型都可以显示编辑
    public int[] array;
    public List<int> list;
    public E_TestEnum testEnum;
    // public GameObject gameObject;

    // 字典不会在Inspector中显示
    // 但是可以使用[System.Serializable]特性来显示,字典怎么都不行
    public Dictionary<string, int> dictionary;
    public MyStruct myStruct;
    public MyClass myClass;
    #endregion

    // 辅助特性
    // [Header("头部")]
    // 有助于在Unity Inspector中组织和分组变量
    [Header("basic settings")]
    public int age;
    public bool sex;
    public int attact;

    [Space()]
    // 悬停注释Tooltip
    [Tooltip("Avoid")]
    public int miss;


    // 修饰数值的范围
    [Range(0, 100)]
    public float luck;


    // 多行显示字符串，默认不写参数显示3行，写参数就是对应行
    [Multiline(2)]
    public string multilineString;

    // 滚动条显示字符串,最小显示3行，最大显示10行，超过之后就会出现滚动条
    [TextArea(3, 5)]
    public string textAreaString;

    // 为变量添加快捷方法
    [ContextMenuItem("ResetM", "ResetMoney")]
    public int money = 100;

    // 为变量添加快捷方法
    private void ResetMoney()
    {
        money = 0;
    }

    // 为方法添加特性可以在Inspector中执行,用来测试的
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
