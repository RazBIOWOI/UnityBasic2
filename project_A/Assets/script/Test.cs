using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduce : MonoBehaviour
{
    private string Name = "�ڽÿ�";
    private int age = 32;
    private string hobby = "����, �ִϸ��̼�, ��ȭ, ����";
    private string job = "�ó����� �۰�";
    private float height = 170f;
    private string MBTI = "INFJ";
    private string food = "�ܹ���";
    private string favoriteColor = "��ũ";
    private string favoriteAnimal = "������";
    private string Animal = "���޶�Ͼ�";


    void Start()
    {
        Debug.Log("���� �̸���" + Name + "�Դϴ�.");
        Debug.Log("���� ���̴� " + age + "�Դϴ�.");
        Debug.Log("���� MBTI�� " + MBTI + "�� ȥ�� ��� ���� �����մϴ�.");
        Debug.Log("�����ϴ� ���� " + hobby + "�̰� " + job + "�� �����ϰ� �ֽ��ϴ�.");
        Debug.Log("�� Ű�� " + height + "cm �Դϴ�.");
        Debug.Log("�ְ�� �����ϴ� ������ " + food + "�Դϴ�.");
        Debug.Log("�����ϴ� ������ " + favoriteColor + "�Դϴ�.");
        Debug.Log(favoriteAnimal + "�� ���� ���� �մϴ�.");
        Debug.Log("Ư�� ���� �� " + Animal + "�� ���� �����մϴ�.");
        Debug.Log("���� ���� ����� ���ڴ� " + Random.Range(1, 100) + "�Դϴ�.");
    }
}
    
