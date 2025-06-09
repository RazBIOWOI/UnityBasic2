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
            Debug.Log("반복문이 실행됐어요");
        }
    }

    public void Gatcha()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101);

            Debug.Log($"랜덤 값: {randomValue} 입니다.");

            if (8 <= count)
            {
                Debug.Log("확정으로 '각청'을 뽑았다!");
                count = 0;
            }
            else if (randomValue <= 10)
            {
                Debug.Log("'각청'을 뽑았다!");
            }
            else if (randomValue <= 30)
            {
                Debug.Log("'모나'를 뽑았다!");
            }
            else
            {
                Debug.Log("'치치'를 뽑았다!");
            }
            
            count++;
        }

        int number = 0;
        while (number < 10)
        {
            int randomValue = Random.Range(1, 101);

            Debug.Log($"랜덤 값: {randomValue} 입니다.");

            if (8 <= count)
            {
                Debug.Log("확정으로 '각청'을 뽑았다!");
                count = 0;
            }
            else if (randomValue <= 10)
            {
                Debug.Log("'각청'을 뽑았다!");
            }
            else if (randomValue <= 30)
            {
                Debug.Log("'모나'를 뽑았다!");
            }
            else
            {
                Debug.Log("'치치'를 뽑았다!");
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
                    Debug.Log("'각청'을 뽑았다!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("'모나'를 뽑았다!");
                }
                else
                {
                    Debug.Log("'치치'를 뽑았다!");
                }
                break;

            case 1:
                 if (randomValue <= 10)
                {
                    Debug.Log("'아야카'을 뽑았다!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("'연비'를 뽑았다!");
                }
                else
                {
                    Debug.Log("'중운'를 뽑았다!");
                }
                break;

            case 2:
                 if (randomValue <= 10)
                {
                    Debug.Log("'미코'을 뽑았다!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("'연비'를 뽑았다!");
                }
                else
                {
                    Debug.Log("'중운'를 뽑았다!");
                }
                break;

            default:
                if (randomValue <= 10)
                {
                    Debug.Log("'노엘'을 뽑았다!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("'레이저'를 뽑았다!");
                }
                else
                {
                    Debug.Log("'행추'를 뽑았다!");
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
