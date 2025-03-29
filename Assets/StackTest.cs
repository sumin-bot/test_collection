using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Stack �ֻ����� ������ �ֻ����� �����Ǵ� �÷���
        // new Ű����� �޸𸮸� �Ҵ�
        Stack stack = new Stack();

        //������ �ֻ����� ���ο� ��� �߰�
        for ( int i = 0 ; i < 5 ; ++i)
        {
            stack.Push(i);
        }

        //���� ���ÿ� ����� ����� ����
        Debug.Log($"Stack Count : {stack.Count}");

        //������ �ֻ��� ���� X, ��� ��ȯ
        Debug.Log($"�������� �߰��� ��� : {stack.Peek()}");

        Debug.Log($"Stack Count : {stack.Count}");

        //������ �ֻ��� ���� O, ��� ��ȯ
        object data = stack.Pop();
        Debug.Log($"���ÿ��� �������� ������ : {data}");

        Debug.Log($"Stack Count : {stack.Count}");

        //������ ��� ��� ����
        stack.Clear();

        Debug.Log($"Stack Count : {stack.Count}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
