using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tools
{
    public static void Sort(this Transform obj) // ��չ������д��
    {
        // ���Ӷ��������ֳ��̽�������
        // ˼·��
        // ��ȡ���е��Ӷ���Ȼ����һ���������洢��Ȼ��������ڰ������ֵĳ��Ƚ�������
        // Ȼ������õ������ڵĶ������������Ӷ����Index
        List<Transform> list = new List<Transform>();
        for (int i=0;i<obj.childCount; i++)
        {
            Transform child = obj.GetChild(i);
            list.Add(child);
        }
        // ����
        list.Sort((a, b) => a.name.Length.CompareTo(b.name.Length));
        // �����Ӷ����Index
        for (int i = 0; i < list.Count; i++)
        {
            list[i].SetSiblingIndex(i);
        }
    }
}
