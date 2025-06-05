using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduce : MonoBehaviour
{
    private string Name = "박시원";
    private int age = 32;
    private string hobby = "게임, 애니메이션, 영화, 음악";
    private string job = "시나리오 작가";
    private float height = 170f;
    private string MBTI = "INFJ";
    private string food = "햄버거";
    private string favoriteColor = "핑크";
    private string favoriteAnimal = "강아지";
    private string Animal = "포메라니안";


    void Start()
    {
        Debug.Log("저의 이름은" + Name + "입니다.");
        Debug.Log("저의 나이는 " + age + "입니다.");
        Debug.Log("저의 MBTI는 " + MBTI + "로 혼자 노는 것을 좋아합니다.");
        Debug.Log("좋아하는 것은 " + hobby + "이고 " + job + "를 지망하고 있습니다.");
        Debug.Log("제 키는 " + height + "cm 입니다.");
        Debug.Log("최고로 좋아하는 음식은 " + food + "입니다.");
        Debug.Log("좋아하는 색깔은 " + favoriteColor + "입니다.");
        Debug.Log(favoriteAnimal + "를 가장 좋아 합니다.");
        Debug.Log("특히 견종 중 " + Animal + "을 가장 좋아합니다.");
        Debug.Log("오늘 저의 행운의 숫자는 " + Random.Range(1, 100) + "입니다.");
    }
}
    
