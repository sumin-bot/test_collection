using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashtableTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Ű�� ������ �̷���� �����͸� �ٷ�� �÷���
        // new Ű����� �޸� �Ҵ�
        Hashtable hash = new Hashtable();

        // object Ÿ���� ���� ���� / ��, Ŭ������ ���� ����
        Goblin goblin = new Goblin();
        Slime slime = new Slime();
        
        // ��� �߰� ( [] ������ )
        hash["Goblin"] = goblin;

        // ��� �߰� ( Add �޼ҵ� )
        hash.Add("Slime", slime);
        hash.Add(1, "����");
        hash.Add(1.2f, "�Ǽ�");
        hash.Add("�ȳ��ϼ���", "���ڿ�");

        // ���� for ���� Ȱ���� ������ Ž�� �Ұ���
        // ���������� ������ Ž���� �Ұ����� �� ���Ǵ� �ݺ���
        foreach ( object key in hash.Keys )
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        // ������̺� ��� Ž�� - Ű
        if ( hash.ContainsKey("Slime") )
        {
            Debug.Log($"Slime Ű ����");
        }

        // ������̺� ��� Ž�� - ��
        if ( hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} �� ����");
        }

        // ����� ����
        Debug.Log($"Hashtable Count : {hash.Count}");

        // ����� ����
        hash.Remove("Slime");

        // ����� ���� (��ü)
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
