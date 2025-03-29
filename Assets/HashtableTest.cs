using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashtableTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 키와 값으로 이루어진 데이터를 다루는 컬렉션
        // new 키워드로 메모리 할당
        Hashtable hash = new Hashtable();

        // object 타입을 저장 가능 / 즉, 클래스도 저장 가능
        Goblin goblin = new Goblin();
        Slime slime = new Slime();
        
        // 요소 추가 ( [] 연산자 )
        hash["Goblin"] = goblin;

        // 요소 추가 ( Add 메소드 )
        hash.Add("Slime", slime);
        hash.Add(1, "정수");
        hash.Add(1.2f, "실수");
        hash.Add("안녕하세요", "문자열");

        // 기존 for 문을 활용해 데이터 탐색 불가능
        // 순차적으로 데이터 탐색이 불가능할 때 사용되는 반복문
        foreach ( object key in hash.Keys )
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        // 헤시테이블 요소 탐색 - 키
        if ( hash.ContainsKey("Slime") )
        {
            Debug.Log($"Slime 키 존재");
        }

        // 헤시테이블 요소 탐색 - 값
        if ( hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} 값 존재");
        }

        // 요소의 개수
        Debug.Log($"Hashtable Count : {hash.Count}");

        // 요소의 삭제
        hash.Remove("Slime");

        // 요소의 삭제 (전체)
        hash.Clear();

        Debug.Log($"Hashtable Count : {hash.Count}");

    }

    public class Goblin { }

    public class Slime { }

    // Update is called once per frame
    void Update()
    {
        
    }
}
