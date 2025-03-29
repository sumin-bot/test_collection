using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Stack 최상위에 들어오고 최상위가 삭제되는 컬렉션
        // new 키워드로 메모리를 할당
        Stack stack = new Stack();

        //스택의 최상위에 새로운 요소 추가
        for ( int i = 0 ; i < 5 ; ++i)
        {
            stack.Push(i);
        }

        //현재 스택에 저장된 요소의 개수
        Debug.Log($"Stack Count : {stack.Count}");

        //스택의 최상위 삭제 X, 요소 반환
        Debug.Log($"마지막의 추가된 요소 : {stack.Peek()}");

        Debug.Log($"Stack Count : {stack.Count}");

        //스택의 최상위 삭제 O, 요소 반환
        object data = stack.Pop();
        Debug.Log($"스택에서 빠져나온 데이터 : {data}");

        Debug.Log($"Stack Count : {stack.Count}");

        //스택의 모든 요소 삭제
        stack.Clear();

        Debug.Log($"Stack Count : {stack.Count}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
