using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    int count;

    void Awake()
    {
        count = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("�ݺ����� ����ƾ��");
        }
    }

    public void Gatcha()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101);

            Debug.Log($"���� ��: {randomValue} �Դϴ�.");

            if (8 <= count)
            {
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
                count = 0;
            }
            else if (randomValue <= 10)
            {
                Debug.Log("'��û'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30)
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("'ġġ'�� �̾Ҵ�!");
            }
            
            count++;
        }

        int number = 0;
        while (number < 10)
        {
            int randomValue = Random.Range(1, 101);

            Debug.Log($"���� ��: {randomValue} �Դϴ�.");

            if (8 <= count)
            {
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
                count = 0;
            }
            else if (randomValue <= 10)
            {
                Debug.Log("'��û'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30)
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("'ġġ'�� �̾Ҵ�!");
            }

            number++;
        }
    }

    public int selectNumber = 5;
    public void GatchaSwitch()
    {
        int randomValue = Random.Range(1, 101);

        switch (selectNumber)
        {
            case 0:
                if (randomValue <= 10)
                {
                    Debug.Log("'��û'�� �̾Ҵ�!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("'��'�� �̾Ҵ�!");
                }
                else
                {
                    Debug.Log("'ġġ'�� �̾Ҵ�!");
                }
                break;

            case 1:
                 if (randomValue <= 10)
                {
                    Debug.Log("'�ƾ�ī'�� �̾Ҵ�!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("'����'�� �̾Ҵ�!");
                }
                else
                {
                    Debug.Log("'�߿�'�� �̾Ҵ�!");
                }
                break;

            case 2:
                 if (randomValue <= 10)
                {
                    Debug.Log("'����'�� �̾Ҵ�!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("'����'�� �̾Ҵ�!");
                }
                else
                {
                    Debug.Log("'�߿�'�� �̾Ҵ�!");
                }
                break;

            default:
                if (randomValue <= 10)
                {
                    Debug.Log("'�뿤'�� �̾Ҵ�!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("'������'�� �̾Ҵ�!");
                }
                else
                {
                    Debug.Log("'����'�� �̾Ҵ�!");
                }
                break;

        }
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
