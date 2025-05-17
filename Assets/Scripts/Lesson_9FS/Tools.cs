using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tools
{
    public static void Sort(this Transform obj) // 拓展方法的写法
    {
        // 将子对象按照名字长短进行排序
        // 思路：
        // 获取所有的子对象，然后用一个容器来存储，然后对容器内按照名字的长度进行排序
        // 然后将排序好的容器内的对象重新设置子对象的Index
        List<Transform> list = new List<Transform>();
        for (int i=0;i<obj.childCount; i++)
        {
            Transform child = obj.GetChild(i);
            list.Add(child);
        }
        // 排序
        list.Sort((a, b) => a.name.Length.CompareTo(b.name.Length));
        // 设置子对象的Index
        for (int i = 0; i < list.Count; i++)
        {
            list[i].SetSiblingIndex(i);
        }
    }
}
