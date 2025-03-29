using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;

public class ArrayListTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ArrayList 용량을 미리 지정할 필요 없는 배열과 흡사한 컬렉션
        // new 키워드로 메모리를 할당
        ArrayList array= new ArrayList();
        
        // ArrayList 정수 10 데이터 저장 + 출력(콘솔창에는 위치 0이 출력)
        Debug.Log(array.Add(10));

        // 데이터 출력
        PrintArrayList(array);

        // 요소 추가 (원하는 위치)
        array.Insert(1, 100);

        // 데이터 출력
        PrintArrayList(array);

        // 요소 추가 (범위, ICollection)
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(2);
        data.Add(3);
        array.AddRange(data); 

        // 데이터정렬 (정수 데이터만 있을 때 가능)
        array.Sort();

        // 데이터 출력
        PrintArrayList(array);

        // 요소 삭제 (매개변수에 입력된 데이터)
        array.Remove(10);

        // 요소 삭제 (매개변수에 입련된 위치의 요소)
        array.RemoveAt(0);

        // 요소 삭제 (첫 번째 매개변수 위치부터 두 번째 매개변수 개수만큼 삭제)
        array.RemoveRange(0, 2);

        // 데이터 출력
        PrintArrayList(array);

        // 모든 요소 삭제
        array.Clear();

        // 요소 개수 출력
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
