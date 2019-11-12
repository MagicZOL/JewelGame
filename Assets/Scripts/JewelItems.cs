using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//보석들의 위치를 지정하는 판넬 스크립트 
public class JewelItems : MonoBehaviour
{
    [SerializeField] GameObject jewelItemButtonPrefab;

    List<JewelItemButton> jewelItemButtonList = new List<JewelItemButton>();

    JewelItemInfos? jewelItemInfos;

    //아이템들이 판넬에 위치
    private void MakeImageCell(Sprite[] sprites)
    {
        foreach (Sprite sprite in sprites)
        {
            JewelItemButton jewelItemButtonScript = Instantiate(jewelItemButtonPrefab, transform).GetComponent<JewelItemButton>();
            jewelItemButtonScript.GetComponentInChildren<Image>().sprite = sprite;
            //jewelItemButtonScript.jewelItemDelegate = this; //델리게이트에 버튼자신의 정보를 알려줌
            jewelItemButtonList.Add(jewelItemButtonScript); //버튼들을 리스트에 저장함

            jewelItemButtonScript.jewelItemDelegate = (jewelItemButton) =>
            {
                if (jewelItemInfos.HasValue)
                {
                    int itemIndex = jewelItemButtonList.IndexOf(jewelItemButton); //아이템이 누군지 알게되는 순간
                                                                                  //Debug.Log("나의 인덱스는 : " + itemIndex);

                    JewelItemInfo selectButton = jewelItemInfos.Value.jewelItemInfoList[itemIndex];
                    jewelItemButtonScript.jewelItemInfo = selectButton;
                }
            };
        }
    }
    private void Awake()
    {
        Sprite[] sprites = SpriteManager.Load();
        MakeImageCell(sprites);

        AddJewelItemInfo();
    }

    //public void DidSelectItem(JewelItemButton jewelItemButton)
    //{
    //    if (jewelItemInfos.HasValue)
    //    {
    //        int itemIndex = jewelItemButtonList.IndexOf(jewelItemButton); //아이템이 누군지 알게되는 순간
    //        //Debug.Log("나의 인덱스는 : " + itemIndex);

    //        JewelItemInfo selectButton = jewelItemInfos.Value.jewelItemInfoList[itemIndex];
    //        jewelItemButtonScript.jewelItemInfo = selectButton;
    //    }
    //}

    void AddJewelItemInfo()
    {
        if (!jewelItemInfos.HasValue)
        {
            List<JewelItemInfo> jewelItemInfoList = new List<JewelItemInfo>();

            JewelItemInfo jewel1;
            jewel1.name = "Pink Jewel";
            jewel1.getPrize = 1000;
            jewel1.prize = 100;
            jewelItemInfoList.Add(jewel1);

            JewelItemInfo jewel2;
            jewel2.name = "Green Jewel";
            jewel2.getPrize = 1000;
            jewel2.prize = 200;
            jewelItemInfoList.Add(jewel2);

            JewelItemInfo jewel3;
            jewel3.name = "Yello Jewel";
            jewel3.getPrize = 1000;
            jewel3.prize = 300;
            jewelItemInfoList.Add(jewel3);

            JewelItemInfo jewel4;
            jewel4.name = "Orange Jewel";
            jewel4.getPrize = 1000;
            jewel4.prize = 400;
            jewelItemInfoList.Add(jewel4);

            JewelItemInfo jewel5;
            jewel5.name = "ThickGreen Jewel";
            jewel5.getPrize = 1000;
            jewel5.prize = 500;
            jewelItemInfoList.Add(jewel5);

            JewelItemInfo jewel6;
            jewel6.name = "Red Jewel";
            jewel6.getPrize = 1000;
            jewel6.prize = 600;
            jewelItemInfoList.Add(jewel6);

            JewelItemInfo jewel7;
            jewel7.name = "Violet Jewel";
            jewel7.getPrize = 1000;
            jewel7.prize = 700;
            jewelItemInfoList.Add(jewel7);

            JewelItemInfo jewel8;
            jewel8.name = "Blue Jewel";
            jewel8.getPrize = 1000;
            jewel8.prize = 800;
            jewelItemInfoList.Add(jewel8);

            JewelItemInfo jewel9;
            jewel9.name = "White Jewel";
            jewel9.getPrize = 1000;
            jewel9.prize = 700;
            jewelItemInfoList.Add(jewel9);

            jewelItemInfos = new JewelItemInfos(jewelItemInfoList);
        }
    }
    //나갈때 저장
    private void OnApplicationQuit()
    {
        if (jewelItemInfos.HasValue)
            FileManager<JewelItemInfos>.Save(jewelItemInfos.Value, Constant.kFileName);
    }
}