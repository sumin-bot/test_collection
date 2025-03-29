using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Queue ���� ����, �Ĵ� �߰��ϴ� �÷���
        // new Ű����� �޸𸮸� �Ҵ�
        Queue queue = new Queue();

        // �Ĵ��� ���ο� ��� �߰�
        for ( int i = 0 ; i < 5 ; ++i )
        {
            queue.Enqueue(i);
        }

        // ���� ť�� ����� ����� ����
        Debug.Log($"Queue Count : {queue.Count}");

        // ���� ���� X, ��� ��ȯ
        Debug.Log($"���� 0�� ��� : {queue.Peek()}");

        Debug.Log($"Queue Count : {queue.Count}");

        // ���� ���� O, ��� ��ȯ
        object data = queue.Dequeue();
        Debug.Log($"ť���� �������� ������ : {data}");

        Debug.Log($"Queue Count : {queue.Count}");

        //ť�� ��� ��� ����
        queue.Clear();

        Debug.Log($"Queue Count : {queue.Count}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
