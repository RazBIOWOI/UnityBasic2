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
            new GatchaItem("�Ҵ�", 0.89f),
            new GatchaItem("Ŭ���� �Ҵ�", 0.89f),
            new GatchaItem("����Į���� �Ҵ�", 0.89f),
            new GatchaItem("������", 0.89f),
            new GatchaItem("Ŭ���� ������", 0.89f),
            new GatchaItem("��Ŭ��", 0.89f),
            new GatchaItem("Ŭ���� ��Ŭ��", 0.89f),
            new GatchaItem("���̹�", 0.89f),
            new GatchaItem("Ŭ���� ���̹�", 0.89f),
            new GatchaItem("ũ��", 0.89f),
            new GatchaItem("��", 0.89f),
            new GatchaItem("������", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("���ް�", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("�����ǿ�", 0.89f),
            new GatchaItem("í��", 0.89f),
            new GatchaItem("���� ���׸�", 0.89f),
            new GatchaItem("��Ż �Ҵ�", 0.89f),
            new GatchaItem("������", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("ť��", 0.89f),
            new GatchaItem("��ī �Ҵ�", 0.89f),
            new GatchaItem("�ȵ���̵� ������", 0.89f),
            new GatchaItem("�ǹ�", 0.89f),
            new GatchaItem("������", 0.89f),
            new GatchaItem("�Ƹ���", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("���׸� �װ�", 0.89f),
            new GatchaItem("���ʷ���", 0.89f),
            new GatchaItem("��Ʈ", 0.89f),
            new GatchaItem("���̺�", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("������", 0.89f),
            new GatchaItem("�����伭 ������ �κ�Ʈ��", 0.89f),
            new GatchaItem("���̺귯�� Ÿ��", 0.89f),
            new GatchaItem("í��", 0.89f),
            new GatchaItem("ƼĮ", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("����í��", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("Ĩ", 0.89f),
            new GatchaItem("������", 0.89f),
            new GatchaItem("��ƽ��", 0.89f),
            new GatchaItem("���� ��", 0.89f),
            new GatchaItem("ī����", 0.89f),
            new GatchaItem("�� ��", 0.89f),
            new GatchaItem("���Ǵ�Ʈ", 0.89f),
            new GatchaItem("�ں�ũ", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("������ ��ũ", 0.89f),
            new GatchaItem("��", 0.89f),
            new GatchaItem("��", 0.89f),
            new GatchaItem("��ũ", 0.89f),
            new GatchaItem("����Ƽ", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("���", 0.89f),
            new GatchaItem("����ī��", 0.89f),
            new GatchaItem("ġ��", 0.89f),
            new GatchaItem("�ٴҶ�", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("������", 0.89f),
            new GatchaItem("�̺���", 0.89f),
            new GatchaItem("�ֶ󸮽�", 0.89f),
            new GatchaItem("�Ҵ� ��", 0.89f),
            new GatchaItem("���̵�", 0.89f),
            new GatchaItem("������Ʈ", 0.89f),
            new GatchaItem("��ũ ���̾�", 0.89f),
            new GatchaItem("��Ŭ ����", 0.89f),
            new GatchaItem("Ÿ������", 0.89f),
            new GatchaItem("����Ȥ", 0.89f),
            new GatchaItem("�ƹ�Ÿ", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("Ʈ��", 0.89f),
            new GatchaItem("���丮�� ����", 0.89f),
            new GatchaItem("��Ŭ��", 0.89f),
            new GatchaItem("���� ���", 0.89f),
            new GatchaItem("���� �ڵ� ���", 0.89f),
            new GatchaItem("����ÿ", 0.89f),
            new GatchaItem("�� ���ڿ콺Ű", 0.89f),
            new GatchaItem("�ŵ� ���ڿ콺Ű", 0.89f),
            new GatchaItem("���̵� ����", 0.89f),
            new GatchaItem("���ͽ�", 0.89f),
            new GatchaItem("�ڽ���", 0.89f),
            new GatchaItem("ũ����", 0.89f),
            new GatchaItem("ô", 0.89f),
            new GatchaItem("�̽��� ��Ÿī", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("���� ����", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("��Ŀ��", 0.89f),
            new GatchaItem("������", 0.89f),
            new GatchaItem("������", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("�����", 0.89f),
            new GatchaItem("�׼�", 0.89f),
            new GatchaItem("��巹��", 0.89f),
            new GatchaItem("����Ƽ��", 0.89f),
            new GatchaItem("ĳ�þ�", 0.89f),
            new GatchaItem("Ŭ�κ�", 0.89f),
            new GatchaItem("��Ŭ��Ʈ", 0.89f),
            new GatchaItem("���", 0.89f),
            new GatchaItem("�����Ʈ", 0.89f),
            new GatchaItem("���", 0.89f),
            new GatchaItem("������ ����", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("�̷����� ��", 0.89f),
            new GatchaItem("�ָ���", 0.89f),
            new GatchaItem("�Ƽ� ��", 0.89f),
            new GatchaItem("�ʱ�", 0.89f),
            new GatchaItem("������", 0.89f),
            new GatchaItem("�־�", 0.89f),
            new GatchaItem("��", 0.89f),
            new GatchaItem("��", 0.89f),
            new GatchaItem("��", 0.89f),
            new GatchaItem("����Ʈ", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("�Һ�", 0.89f),
            new GatchaItem("���� ��Ÿ����", 0.89f),
            new GatchaItem("�̹�", 0.89f),
            new GatchaItem("Ŭ��ġ", 0.89f),
            new GatchaItem("����", 0.89f),
            new GatchaItem("Ű������", 0.89f)
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
