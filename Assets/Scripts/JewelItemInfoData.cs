using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//아이템의 정보를 저장
[System.Serializable]
public struct JewelEquipItemData
{
    public string name;     //이름
    public int speed;    //스피드
    public int attack;   //공격력
    public int buyprize; //살때 가격
    public int count;    //보유개수
    public int sellPrize;//팔때 가격
    public string description; //설명
}

public struct JewelEquipItemDatas
{
    public List<JewelEquipItemData> jewelEquipItemList;

    public JewelEquipItemDatas(List<JewelEquipItemData> jewelEquipItemList)
    {
        this.jewelEquipItemList = jewelEquipItemList;
    }
}

public class JewelItemInfoData :MonoBehaviour
{
    JewelEquipItemDatas? jewelEquipItemDatas;

    [SerializeField] TabChangePanel tabChangePanel;
    private void Awake()
    {
        if (!jewelEquipItemDatas.HasValue)
        {
            ItemData();
        }
    }

    void ItemData()
    {
            List<JewelEquipItemData> jewelEquipItemDataList = new List<JewelEquipItemData>();

            JewelEquipItemData item1;
            item1.name = "낫";
            item1.speed = 10;
            item1.attack = 10;
            item1.buyprize = 1000;
            item1.count = 1;
            item1.sellPrize = 100;
            item1.description = "캐기 좋은 낫이다.";
            jewelEquipItemDataList.Add(item1);

            JewelEquipItemData item2;
            item2.name = "곡괭이";
            item2.speed = 20;
            item2.attack = 20;
            item2.buyprize = 2000;
            item2.count = 1;
            item2.sellPrize = 200;
            item2.description = "캐기 좋은 곡괭이이다.";
            jewelEquipItemDataList.Add(item2);

            JewelEquipItemData item3;
            item3.name = "황금곡괭이";
            item3.speed = 30;
            item3.attack = 30;
            item3.buyprize = 3000;
            item3.count = 1;
            item3.sellPrize = 300;
            item3.description = "캐기 좋은 황금곡괭이이다.";
            jewelEquipItemDataList.Add(item3);

            JewelEquipItemData item4;
            item4.name = "드릴";
            item4.speed = 40;
            item4.attack = 40;
            item4.buyprize = 4000;
            item4.count = 1;
            item4.sellPrize = 100;
            item4.description = "업그레이드된 드릴이다.";
            jewelEquipItemDataList.Add(item4);

            JewelEquipItemData item5;
            item5.name = "단단한 드릴";
            item5.speed = 50;
            item5.attack = 50;
            item5.buyprize = 5000;
            item5.count = 1;
            item5.sellPrize = 500;
            item5.description = "고장이 없는 드릴이다.";
            jewelEquipItemDataList.Add(item5);

            JewelEquipItemData item6;
            item6.name = "황금빛 드릴";
            item6.speed = 60;
            item6.attack = 60;
            item6.buyprize = 6000;
            item6.count = 1;
            item6.sellPrize = 600;
            item6.description = "황금빛이 나는 드릴이다.";
            jewelEquipItemDataList.Add(item6);

            JewelEquipItemData item7;
            item7.name = "우주드릴";
            item7.speed = 70;
            item7.attack = 70;
            item7.buyprize = 7000;
            item7.count = 1;
            item7.sellPrize = 700;
            item7.description = "우주에서 주워온 드릴이다.";
            jewelEquipItemDataList.Add(item7);

            JewelEquipItemData item8;
            item8.name = "풀장착중";
            item8.speed = 80;
            item8.attack = 80;
            item8.buyprize = 8000;
            item8.count = 1;
            item8.sellPrize = 800;
            item8.description = "이제 당신은 광부의 신!";
            jewelEquipItemDataList.Add(item8);

            JewelEquipItemData item9;
            item9.name = "풀장착중";
            item9.speed = 90;
            item9.attack = 90;
            item9.buyprize = 9000;
            item9.count = 1;
            item9.sellPrize = 900;
            item9.description = "이제 당신은 광부의 신!";
            jewelEquipItemDataList.Add(item9);

            JewelEquipItemData item10;
            item10.name = "풀장착중";
            item10.speed = 100;
            item10.attack = 100;
            item10.buyprize = 10000;
            item10.count = 1;
            item10.sellPrize = 1000;
            item10.description = "이제 당신은 광부의 신!";
            jewelEquipItemDataList.Add(item10);

            JewelEquipItemData item11;
            item11.name = "풀장착중";
            item11.speed = 110;
            item11.attack = 110;
            item11.buyprize = 110000;
            item11.count = 1;
            item11.sellPrize = 1100;
            item11.description = "이제 당신은 광부의 신!";
            jewelEquipItemDataList.Add(item11);

            JewelEquipItemData item12;
            item12.name = "풀장착중";
            item12.speed = 120;
            item12.attack = 120;
            item12.buyprize = 12000;
            item12.count = 1;
            item12.sellPrize = 1200;
            item12.description = "이제 당신은 광부의 신!";
            jewelEquipItemDataList.Add(item12);

            JewelEquipItemData item13;
            item13.name = "풀장착중";
            item13.speed = 130;
            item13.attack = 130;
            item13.buyprize = 13000;
            item13.count = 1;
            item13.sellPrize = 1300;
            item13.description = "이제 당신은 광부의 신!";
            jewelEquipItemDataList.Add(item13);

            JewelEquipItemData item14;
            item14.name = "풀장착중";
            item14.speed = 140;
            item14.attack = 140;
            item14.buyprize = 14000;
            item14.count = 1;
            item14.sellPrize = 1400;
            item14.description = "이제 당신은 광부의 신!";
            jewelEquipItemDataList.Add(item14);

            JewelEquipItemData item15;
            item15.name = "풀장착중";
            item15.speed = 150;
            item15.attack = 150;
            item15.buyprize = 15000;
            item15.count = 1;
            item15.sellPrize = 1500;
            item15.description = "이제 당신은 광부의 신!";
            jewelEquipItemDataList.Add(item15);

            JewelEquipItemData item16;
            item16.name = "풀장착중";
            item16.speed = 160;
            item16.attack = 160;
            item16.buyprize = 16000;
            item16.count = 1;
            item16.sellPrize = 1600;
            item16.description = "이제 당신은 광부의 신!";
            jewelEquipItemDataList.Add(item16);

            jewelEquipItemDatas = new JewelEquipItemDatas(jewelEquipItemDataList);
            tabChangePanel.jewelEquipItemDatas = jewelEquipItemDatas;
    }
    private void OnApplicationQuit()
    {
        if (jewelEquipItemDatas.HasValue)
        {
            FileManager<JewelEquipItemDatas>.Save(jewelEquipItemDatas.Value, Constant.ItemFileName);
        }
    }
}

