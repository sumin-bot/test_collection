using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Queue 전단 삭제, 후단 추가하는 컬렉션
        // new 키워드로 메모리를 할당
        Queue queue = new Queue();

        // 후단의 새로운 요소 추가
        for ( int i = 0 ; i < 5 ; ++i )
        {
            queue.Enqueue(i);
        }

        // 현재 큐에 저장된 요소의 개수
        Debug.Log($"Queue Count : {queue.Count}");

        // 전단 삭제 X, 요소 반환
        Debug.Log($"현재 0번 요소 : {queue.Peek()}");

        Debug.Log($"Queue Count : {queue.Count}");

        // 전단 삭제 O, 요소 반환
        object data = queue.Dequeue();
        Debug.Log($"큐에서 빠져나온 데이터 : {data}");

        Debug.Log($"Queue Count : {queue.Count}");

        //큐의 모든 요소 삭제
        queue.Clear();

        Debug.Log($"Queue Count : {queue.Count}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
