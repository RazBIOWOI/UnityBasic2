using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class gachaScript : MonoBehaviour
{
    public Button rollButton;
    public TextMeshProUGUI[] resultBoxes;

    public class GatchaItem
    {
        public string Name;
        public float Probability;

        public GatchaItem(string name, float probability)
        {
            Name = name;
            Probability = probability;
        }
    }

    private List<GatchaItem> gatchaPool = new List<GatchaItem>();

    void Start()
    {
        rollButton.onClick.AddListener(RollTenTimes);

        List<GatchaItem> characterList = new List<GatchaItem>
        {
            new GatchaItem("소닉", 0.89f),
            new GatchaItem("클래식 소닉", 0.89f),
            new GatchaItem("엑스칼리버 소닉", 0.89f),
            new GatchaItem("테일즈", 0.89f),
            new GatchaItem("클래식 테일즈", 0.89f),
            new GatchaItem("너클즈", 0.89f),
            new GatchaItem("클래식 너클즈", 0.89f),
            new GatchaItem("에이미", 0.89f),
            new GatchaItem("클래식 에이미", 0.89f),
            new GatchaItem("크림", 0.89f),
            new GatchaItem("빅", 0.89f),
            new GatchaItem("섀도우", 0.89f),
            new GatchaItem("루즈", 0.89f),
            new GatchaItem("오메가", 0.89f),
            new GatchaItem("벡터", 0.89f),
            new GatchaItem("에스피오", 0.89f),
            new GatchaItem("챠미", 0.89f),
            new GatchaItem("닥터 에그맨", 0.89f),
            new GatchaItem("메탈 소닉", 0.89f),
            new GatchaItem("세이지", 0.89f),
            new GatchaItem("오봇", 0.89f),
            new GatchaItem("큐봇", 0.89f),
            new GatchaItem("메카 소닉", 0.89f),
            new GatchaItem("안드로이드 섀도우", 0.89f),
            new GatchaItem("실버", 0.89f),
            new GatchaItem("블레이즈", 0.89f),
            new GatchaItem("아리엠", 0.89f),
            new GatchaItem("마린", 0.89f),
            new GatchaItem("에그맨 네가", 0.89f),
            new GatchaItem("메필레스", 0.89f),
            new GatchaItem("제트", 0.89f),
            new GatchaItem("웨이브", 0.89f),
            new GatchaItem("스톰", 0.89f),
            new GatchaItem("마리아", 0.89f),
            new GatchaItem("프로페서 제럴드 로보트닉", 0.89f),
            new GatchaItem("에이브러햄 타워", 0.89f),
            new GatchaItem("챠오", 0.89f),
            new GatchaItem("티칼", 0.89f),
            new GatchaItem("감마", 0.89f),
            new GatchaItem("오모챠오", 0.89f),
            new GatchaItem("에멜", 0.89f),
            new GatchaItem("칩", 0.89f),
            new GatchaItem("위스프", 0.89f),
            new GatchaItem("스틱스", 0.89f),
            new GatchaItem("도돈 파", 0.89f),
            new GatchaItem("카오스", 0.89f),
            new GatchaItem("블랙 둠", 0.89f),
            new GatchaItem("인피니트", 0.89f),
            new GatchaItem("자보크", 0.89f),
            new GatchaItem("자즈", 0.89f),
            new GatchaItem("조몸", 0.89f),
            new GatchaItem("지나", 0.89f),
            new GatchaItem("조어", 0.89f),
            new GatchaItem("마스터 지크", 0.89f),
            new GatchaItem("팡", 0.89f),
            new GatchaItem("빈", 0.89f),
            new GatchaItem("바크", 0.89f),
            new GatchaItem("마이티", 0.89f),
            new GatchaItem("레이", 0.89f),
            new GatchaItem("허니", 0.89f),
            new GatchaItem("파차카마", 0.89f),
            new GatchaItem("치즈", 0.89f),
            new GatchaItem("바닐라", 0.89f),
            new GatchaItem("지멜", 0.89f),
            new GatchaItem("엘리스", 0.89f),
            new GatchaItem("이블리스", 0.89f),
            new GatchaItem("솔라리스", 0.89f),
            new GatchaItem("소닉 맨", 0.89f),
            new GatchaItem("셰이드", 0.89f),
            new GatchaItem("이프리트", 0.89f),
            new GatchaItem("다크 가이아", 0.89f),
            new GatchaItem("피클 교수", 0.89f),
            new GatchaItem("타임이터", 0.89f),
            new GatchaItem("웨어혹", 0.89f),
            new GatchaItem("아바타", 0.89f),
            new GatchaItem("코코", 0.89f),
            new GatchaItem("트립", 0.89f),
            new GatchaItem("빅토리아 교수", 0.89f),
            new GatchaItem("롱클로", 0.89f),
            new GatchaItem("스톤 요원", 0.89f),
            new GatchaItem("랜들 핸들 요원", 0.89f),
            new GatchaItem("레이첼", 0.89f),
            new GatchaItem("톰 와코우스키", 0.89f),
            new GatchaItem("매디 와코우스키", 0.89f),
            new GatchaItem("웨이드 휘플", 0.89f),
            new GatchaItem("월터스", 0.89f),
            new GatchaItem("코스모", 0.89f),
            new GatchaItem("크리스", 0.89f),
            new GatchaItem("척", 0.89f),
            new GatchaItem("미스터 다타카", 0.89f),
            new GatchaItem("니콜", 0.89f),
            new GatchaItem("버니 래벗", 0.89f),
            new GatchaItem("로터", 0.89f),
            new GatchaItem("샐리", 0.89f),
            new GatchaItem("스커지", 0.89f),
            new GatchaItem("앙투안", 0.89f),
            new GatchaItem("에너작", 0.89f),
            new GatchaItem("찰스", 0.89f),
            new GatchaItem("툰드라", 0.89f),
            new GatchaItem("액셀", 0.89f),
            new GatchaItem("모드레드", 0.89f),
            new GatchaItem("네프티스", 0.89f),
            new GatchaItem("캐시아", 0.89f),
            new GatchaItem("클로브", 0.89f),
            new GatchaItem("아클루트", 0.89f),
            new GatchaItem("어비스", 0.89f),
            new GatchaItem("썬더볼트", 0.89f),
            new GatchaItem("모우", 0.89f),
            new GatchaItem("정복자 스톰", 0.89f),
            new GatchaItem("샤라", 0.89f),
            new GatchaItem("이레이저 진", 0.89f),
            new GatchaItem("멀리나", 0.89f),
            new GatchaItem("아서 왕", 0.89f),
            new GatchaItem("탱글", 0.89f),
            new GatchaItem("위스퍼", 0.89f),
            new GatchaItem("주얼", 0.89f),
            new GatchaItem("라놀린", 0.89f),
            new GatchaItem("벨", 0.89f),
            new GatchaItem("돈", 0.89f),
            new GatchaItem("나이트", 0.89f),
            new GatchaItem("러프", 0.89f),
            new GatchaItem("텀블", 0.89f),
            new GatchaItem("닥터 스타라인", 0.89f),
            new GatchaItem("미믹", 0.89f),
            new GatchaItem("클러치", 0.89f),
            new GatchaItem("서지", 0.89f),
            new GatchaItem("키츠나미", 0.89f)
        };

        gatchaPool.AddRange(characterList);
    }

    void RollTenTimes()
    {
        for (int i = 0; i < resultBoxes.Length; i++)
        {
            string result = RollOnce();
            resultBoxes[i].text = result;
        }
    }

    string RollOnce()
    {
        int index = Random.Range(0, gatchaPool.Count);
        return gatchaPool[index].Name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
