using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;

public class ArrayListTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ArrayList �뷮�� �̸� ������ �ʿ� ���� �迭�� ����� �÷���
        // new Ű����� �޸𸮸� �Ҵ�
        ArrayList array= new ArrayList();
        
        // ArrayList ���� 10 ������ ���� + ���(�ܼ�â���� ��ġ 0�� ���)
        Debug.Log(array.Add(10));

        // ������ ���
        PrintArrayList(array);

        // ��� �߰� (���ϴ� ��ġ)
        array.Insert(1, 100);

        // ������ ���
        PrintArrayList(array);

        // ��� �߰� (����, ICollection)
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(2);
        data.Add(3);
        array.AddRange(data); 

        // ���������� (���� �����͸� ���� �� ����)
        array.Sort();

        // ������ ���
        PrintArrayList(array);

        // ��� ���� (�Ű������� �Էµ� ������)
        array.Remove(10);

        // ��� ���� (�Ű������� �Էõ� ��ġ�� ���)
        array.RemoveAt(0);

        // ��� ���� (ù ��° �Ű����� ��ġ���� �� ��° �Ű����� ������ŭ ����)
        array.RemoveRange(0, 2);

        // ������ ���
        PrintArrayList(array);

        // ��� ��� ����
        array.Clear();

        // ��� ���� ���
        Debug.Log(array.Count);

    }

    private void PrintArrayList(ArrayList list)
    {
        Debug.Log("==========================");

        for ( int i = 0 ; i < list.Count ; ++i )
        {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
